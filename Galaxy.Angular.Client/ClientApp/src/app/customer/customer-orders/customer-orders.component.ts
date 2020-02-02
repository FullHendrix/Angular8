import { Component, OnInit, Input, ViewChild } from '@angular/core';
import { IOrderGrid } from '../../shared/models/iorder-grid';
import { MatPaginator, MatSort, MatTableDataSource } from '@angular/material';
import { ActivatedRoute, Params } from '@angular/router';
import { DataService } from '../../core/services/data.service';
@Component({
  selector: 'app-customer-orders',
  templateUrl: './customer-orders.component.html',
  styleUrls: ['./customer-orders.component.scss']
})
export class CustomerOrdersComponent implements OnInit {
  @Input() orders: IOrderGrid[] = [];
  displayedColumns: string[] = ['OrderId', 'Customer'];
  @ViewChild(MatPaginator, { static: true }) paginator: MatPaginator;
  @ViewChild(MatSort, { static: true }) sort: MatSort;
  dataSource: MatTableDataSource<IOrderGrid>;

  constructor(private route: ActivatedRoute, private dataService: DataService,

) { }

  ngOnInit() {
    this.route.parent.params.subscribe((params: Params) => {
      const id = + params['id'];
      this.dataService.getOrders(id).subscribe((response: IOrderGrid[]) => {
        this.orders = response;
        this.loadData(this.orders);
      });;

      //if (id !== 0) {
      //  this.operationText = 'Update';
      //  this.getCustomer(id);
      //}
    });
  }
  loadData(data: IOrderGrid[]) {
    this.dataSource = new MatTableDataSource<IOrderGrid>(data)
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;
  }
}
