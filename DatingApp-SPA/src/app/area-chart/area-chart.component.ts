import {
  Component,
  OnInit,
  ElementRef,
  ViewEncapsulation,
  Input,
  SimpleChange,
  OnChanges,
  SimpleChanges
} from "@angular/core";

import * as d3 from "d3";

@Component({
  selector: "app-area-chart",
  templateUrl: "./area-chart.component.html",
  styleUrls: ["./area-chart.component.css"]
})
export class AreaChartComponent implements OnInit, OnChanges {
  @Input() transitionTime = 1000;
  @Input() xmax = 45;
  @Input() ymax = 200;
  @Input() hticks = 60;
  @Input() data: number[];
  @Input() showLabel = 1;
  hostElement; // Native element hosting th SVG container
  svg; // Top level SVG element
  g; // SVG Group element
  colorScale; // D3 color provider
  x; // X-axis graphical coordinates
  y; // Y-axis graphical coordinates
  colors = d3.scaleOrdinal(d3.schemeCategory10);
  bins; // Array of frequency distributions - one for each area chaer
  paths; // Path elements for each area chart
  area; // For D3 histogram function
  histogram; // For D3 histogram function

  constructor(private elRef: ElementRef) {
    this.hostElement = this.elRef.nativeElement;
  }

  ngOnInit() {}

  ngOnChanges(changes: SimpleChanges) {
    if (changes.data) {
      this.updateChart(changes.data.currentValue);
    }
  }
  public updateChart(data: number[]) {
    if (!this.svg) {
      this.createChart(data);
      return;
    }
  }
  public createChart(data: number[]) {
    this.removeExistingChartFromParent();

    this.setChartDimensions();

    this.setColorScale();

    this.addGraphicsElement();

    this.creatXAxis();

    this.createYAxis();

    // d3 area and histogram functions has to be declared after x and y fucntion are defined
    this.area = d3
      .area()
      .x((datum: any) => this.x(d3.mean([datum.x1, datum.x2])))
      .y0(this.y(0))
      .y1((datum: any) => this.y(datum.length));

    this.histogram = d3
      .histogram()
      .value(datum => datum)
      .domain([0, this.xmax])
      .thresholds(this.x.ticks(this.hticks));

    // data has to be processed after area and histogram functions are defined
    this.processData(data);

    this.createAreaChart();
  }
  createAreaChart() {
    throw new Error("Method not implemented.");
  }
  processData(data: number[]) {
    throw new Error("Method not implemented.");
  }
  createYAxis() {
    throw new Error("Method not implemented.");
  }
  creatXAxis() {
    throw new Error("Method not implemented.");
  }
  addGraphicsElement() {
    throw new Error("Method not implemented.");
  }
  setColorScale() {
    throw new Error("Method not implemented.");
  }
  setChartDimensions() {
    throw new Error("Method not implemented.");
  }
  removeExistingChartFromParent() {
    throw new Error("Method not implemented.");
  }
}
