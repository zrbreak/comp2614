﻿using System;
using System.ComponentModel;
using System.Linq;

public class ClientCollection : BindingList<Client>
{

	public ClientCollection()
	{

	}

    decimal TotalYTDSales => this.Sum(x => x.YtdSales);

    int CreditHoldCount => this.Count(x => x.IsCreditHold = true);

}
