//
//  ViewController.swift
//  Dog Years
//
//  Created by Jason Horsman on 7/13/17.
//  Copyright © 2017 JayPr1me Software. All rights reserved.
//

import UIKit

class ViewController: UIViewController {
    @IBOutlet weak var mAgeTextField: UITextField!
    @IBOutlet weak var mAgeDisplay: UILabel!
    @IBAction func submitButtonTapped(_ sender: Any) {
        mAgeDisplay.text = String(Int(mAgeTextField.text!)! * 7)
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

