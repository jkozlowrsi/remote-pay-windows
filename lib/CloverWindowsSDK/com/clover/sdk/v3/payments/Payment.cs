/**
 * Autogenerated by Avro
 * 
 * DO NOT EDIT DIRECTLY
 */

// Copyright (C) 2018 Clover Network, Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
//
// You may obtain a copy of the License at
//    http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System.Collections.Generic;
using com.clover.sdk.v3.base_;

namespace com.clover.sdk.v3.payments
{
    public class Payment
    {

        /// <summary>
        /// Unique identifier
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// The order with which the payment is associated
        /// </summary>
        public Reference order { get; set; }

        /// <summary>
        /// Device which processed the transaction for this payment
        /// </summary>
        public Reference device { get; set; }

        /// <summary>
        /// The tender type associated with this payment, e.g. credit card, cash, etc.
        /// </summary>
        public Tender tender { get; set; }

        /// <summary>
        /// Total amount paid
        /// </summary>
        public long amount { get; set; }

        /// <summary>
        /// Amount paid in tips
        /// </summary>
        public long? tipAmount { get; set; }

        /// <summary>
        /// Amount paid in tax
        /// </summary>
        public long taxAmount { get; set; }

        /// <summary>
        /// Amount given back in a cash back transaction
        /// </summary>
        public long cashbackAmount { get; set; }

        /// <summary>
        /// Amount of cash given by the customer
        /// </summary>
        public long? cashTendered { get; set; }

        public string externalPaymentId { get; set; }

        /// <summary>
        /// The employee who processed the payment
        /// </summary>
        public com.clover.sdk.v3.base_.Reference employee { get; set; }

        /// <summary>
        /// Time payment was recorded on server
        /// </summary>
        public long createdTime { get; set; }

        public long clientCreatedTime { get; set; }

        /// <summary>
        /// Last modified time of the payment
        /// </summary>
        public long modifiedTime { get; set; }

        public bool offline { get; set; }

        public com.clover.sdk.v3.payments.Result result { get; set; }

        /// <summary>
        /// Information about the card used for credit/debit card payments
        /// </summary>
        public com.clover.sdk.v3.payments.CardTransaction cardTransaction { get; set; }

        /// <summary>
        /// Amount record as a service charge
        /// </summary>
        public com.clover.sdk.v3.payments.ServiceChargeAmount serviceCharge { get; set; }

        public List<com.clover.sdk.v3.payments.PaymentTaxRate> taxRates { get; set; }

        public List<com.clover.sdk.v3.payments.Refund> refunds { get; set; }

        public string note { get; set; }

        public List<com.clover.sdk.v3.payments.LineItemPayment> lineItemPayments { get; set; }

        public List<com.clover.sdk.v3.payments.AdditionalChargeAmount> additionalCharges { get; set; }

        /// <summary>
        /// If voided, the reason why (when available)
        /// </summary>
        public com.clover.sdk.v3.order.VoidReason voidReason { get; set; }

        /// <summary>
        /// Dynamic Currency Conversion information
        /// </summary>
        public payments.DCCInfo dccInfo { get; set; }
        /// <summary>
        /// Per transaction settings for the payment
        /// </summary>
        public TransactionSettings transactionSettings { get; set; }
        /// <summary>
        /// German region-specific information
        /// </summary>
        public GermanInfo germanInfo { get; set; }
        /// <summary>
        /// Tracking information for the app that created this payment.
        /// </summary>
        public AppTracking appTracking { get; set; }
        /// <summary>
        /// Information specific to cash advance transactions.
        /// </summary>
        public CashAdvanceExtra cashAdvanceExtra { get; set; }
        /// <summary>
        /// Transaction information
        /// </summary>
        public TransactionInfo transactionInfo { get; set; }
        /// <summary>
        /// Information displayed to customer for storing electronic signatures
        /// </summary>
        public SignatureDisclaimer signatureDisclaimer { get; set; }
        /// <summary>
        /// The external reference id if associated with the payment
        /// </summary>
        public string externalReferenceId { get; set; }
        /// <summary>
        /// Merchant associated with the payment
        /// </summary>
        public Reference merchant { get; set; }
    }

}
