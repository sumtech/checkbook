﻿// Copyright (c) Palouse Coding Conglomerate. All Rights Reserved.

namespace Checkbook.Api.Models
{
    using System.Collections.Generic;

    /// <summary>
    /// Represents a budget to which finances are being allocated for a future
    /// expense.
    /// </summary>
    public class Budget
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Budget"/> class.
        /// </summary>
        public Budget()
        {
            this.TransactionItems = new List<TransactionItem>();
        }

        /// <summary>
        /// Gets or sets the unique identifier for this budget.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the name of this budget.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier for the category to which this
        /// budget is associated.
        /// </summary>
        public long CategoryId { get; set; }

        /// <summary>
        /// Gets or sets the category to which this budget is associated.
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier for the user to which this
        /// budget belongs.
        /// </summary>
        public long UserId { get; set; }

        /// <summary>
        /// Gets or sets the user to which this budgetbelongs.
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// Gets or sets the transaction items that are associated with this
        /// budget.
        /// </summary>
        public List<TransactionItem> TransactionItems { get; set; }
    }
}
