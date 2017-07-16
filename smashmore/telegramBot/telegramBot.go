package main

import (
	"context"
	"encoding/json"
	"errors"
	"log"
	"net/http"

	"github.com/go-kit/kit/endpoint"
	httptransport "github.com/go-kit/kit/transport/http"
)

// TelegramService provides operations on strings.
type TelegramService interface {
	Echo(string) string
}

type telegramService struct{}

func (telegramService) Echo(s string) string {
	return s
}

func main() {
	svc := telegramService{}

	echoHandler := httptransport.NewServer(
		makeEchoEndpoint(svc),
		decodeEchoRequest,
		encodeResponse,
	)

	http.Handle("/echo", echoHandler)
	log.Fatal(http.ListenAndServe(":8080", nil))
}

func makeEchoEndpoint(svc TelegramService) endpoint.Endpoint {
	return func(ctx context.Context, request interface{}) (interface{}, error) {
		req := request.(echoRequest)
		v := svc.Echo(req.S)
		return echoResponse{v}, nil
	}
}

func decodeEchoRequest(_ context.Context, r *http.Request) (interface{}, error) {
	var request echoRequest
	if err := json.NewDecoder(r.Body).Decode(&request); err != nil {
		return nil, err
	}
	return request, nil
}

func encodeResponse(_ context.Context, w http.ResponseWriter, response interface{}) error {
	return json.NewEncoder(w).Encode(response)
}

type echoRequest struct {
	S string `json:"s"`
}

type echoResponse struct {
	S string `json:"s"`
}

// ErrEmpty is returned when an input string is empty.
var ErrEmpty = errors.New("empty string")
