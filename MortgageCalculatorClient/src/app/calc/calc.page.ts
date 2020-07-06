import { Component, OnInit } from '@angular/core';
import { MortgagePaymentService } from '../services/mortgage-payment.service';

@Component({
  selector: 'app-calc',
  templateUrl: './calc.page.html',
  styleUrls: ['./calc.page.scss'],
})

export class CalcPage implements OnInit {

  houseAmount = 0;
  downPayment = 0;
  interestRate = 0;
  loanPeriod = 0;
  finalResult = 0;

  constructor(private mortgagePaymentService: MortgagePaymentService) { }

  ngOnInit() {
  }

  public async calculateMortgagePayment() {
    //alert('Code behind reached!');
    var result = 
    await this.mortgagePaymentService.calculateMortgagePayment(
      this.houseAmount, this.downPayment, this.interestRate, this.loanPeriod);
    this.finalResult = Math.round(result * 100) / 100;
  }

}
