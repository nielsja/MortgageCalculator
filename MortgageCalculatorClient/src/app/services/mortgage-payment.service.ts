import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class MortgagePaymentService {

  constructor(private httpClient: HttpClient) { }

  public async calculateMortgagePayment(
    houseAmount: number,
    downPayment: number,
    interestRate: number,
    loanPeriod: number
  ): Promise<number> {

    //alert('Mortgage Payment Service - calculateMortgagePayment method reached');
    return this.httpClient.get<number>(
      'https://studenttestapps.azurewebsites.net/House/CalculateMortgagePayment' +
      //'https://localhost:44347/House/CalculateMortgagePayment' +
       '?houseAmount=' + houseAmount +
       '&downPayment=' + downPayment +
       '&annualInterestRate=' + interestRate +
       '&loanPeriod=' + loanPeriod).toPromise();
  }

  public async calculateMultipleMortgagePayments(
    downPayment: number,
    interestRate: number,
    loanPeriod: number
  ): Promise<number[]> {

    //alert('Mortgage Payment Service - calculateMortgagePayment method reached');
    return this.httpClient.get<number[]>(
      //'https://localhost:44347/House/CalculateMultipleMortgagePayments' +
      'https://studenttestapps.azurewebsites.net/House/CalculateMultipleMortgagePayments' +
       '?downPayment=' + downPayment +
       '&annualInterestRate=' + interestRate +
       '&loanPeriod=' + loanPeriod).toPromise();
  }
}
