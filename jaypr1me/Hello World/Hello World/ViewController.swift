//
//  ViewController.swift
//  Hello World
//
//  Created by Jason Horsman on 7/10/17.
//  Copyright © 2017 JayPr1me Software. All rights reserved.
//

import UIKit

class ViewController: UIViewController {
    @IBOutlet weak var mNameTextField: UITextField!
    @IBOutlet weak var mGreetingLabel: UILabel!
    
    @IBAction func submitButtonTapped(_ sender: Any) {
        mGreetingLabel.text = "Hi, " + mNameTextField.text!
    }
    
    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view, typically from a nib.
    }

    override func didReceiveMemoryWarning() {
        super.didReceiveMemoryWarning()
        // Dispose of any resources that can be recreated.
    }


}

