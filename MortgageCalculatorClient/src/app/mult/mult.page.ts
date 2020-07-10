import { Component, OnInit } from '@angular/core';
import { MortgagePaymentService } from '../services/mortgage-payment.service';

@Component({
  selector: 'app-mult',
  templateUrl: './mult.page.html',
  styleUrls: ['./mult.page.scss'],
})
export class MultPage implements OnInit {

  mortgagePayments = [10, 20, 30];

  constructor(private mortgagePaymentService: MortgagePaymentService) { }

  async ngOnInit() {
    this.mortgagePayments = 
    await this.mortgagePaymentService.calculateMultipleMortgagePayments(1000, .12, 30);
  }
}
