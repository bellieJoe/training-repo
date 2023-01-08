package org.mobileapp.jardelezajoshua.feelectricbill;

import androidx.appcompat.app.AppCompatActivity;

import android.app.AlertDialog;
import android.content.DialogInterface;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }
    public void calculate(View v){
        EditText previous = (EditText) findViewById(R.id.txtPrevious);
        EditText current = (EditText) findViewById(R.id.txtCurrent);
        Button clear1 = (Button) findViewById(R.id.btnClear1);
        Button compute = (Button) findViewById(R.id.btnCompute);
        TextView consumption = (TextView) findViewById(R.id.txtConsumption);

        if(previous.getText().length() == 0 || current.getText().length() == 0){
            Toast.makeText(MainActivity.this, "Consumptions required", Toast.LENGTH_SHORT).show();
            return;
        }
        if(Integer.parseInt(current.getText().toString()) < Integer.parseInt(previous.getText().toString())){
            Toast.makeText(this, "Current should be greater than previous", Toast.LENGTH_SHORT).show();
            return;
        }
        consumption.setText(Integer.toString(Integer.parseInt(current.getText().toString()) - Integer.parseInt(previous.getText().toString())));
        clear1.setEnabled(true);
        compute.setEnabled(true);

    }

    public void clearConsumptions(View v){
        EditText previous = (EditText) findViewById(R.id.txtPrevious);
        EditText current = (EditText) findViewById(R.id.txtCurrent);
        Button clear1 = (Button) findViewById(R.id.btnClear1);
        Button compute = (Button) findViewById(R.id.btnCompute);
        TextView consumption = (TextView) findViewById(R.id.txtConsumption);

        previous.setText("");
        current.setText("");
        consumption.setText("");
        clear1.setEnabled(false);
        compute.setEnabled(false);
    }

    public void clearRate(View v){
        EditText rate = (EditText) findViewById(R.id.txtRate);
        Button clear2 = (Button) findViewById(R.id.btnClear2);
        TextView electricBill = (TextView) findViewById(R.id.txtElectricBill);

        rate.setText("");
        electricBill.setText("");
        clear2.setEnabled(false);
    }

    public void about(View v){
        Intent i = new Intent(MainActivity.this, AboutActivity.class);
        startActivity(i);
    }

    public void compute(View v){
        EditText rate = (EditText) findViewById(R.id.txtRate);
        Button clear2 = (Button) findViewById(R.id.btnClear2);
        TextView consumption = (TextView) findViewById(R.id.txtConsumption);
        TextView electricBill = (TextView) findViewById(R.id.txtElectricBill);

        if(rate.getText().length() == 0){
            Toast.makeText(this, "Rate is required", Toast.LENGTH_SHORT).show();
            return;
        }
        clear2.setEnabled(true);
        electricBill.setText(
                Integer.toString(
                        (Integer.parseInt(consumption.getText().toString()) * Integer.parseInt(rate.getText().toString()))
                )
        );
    }

    @Override
    public void onBackPressed() {
        // Show an alert dialog
        new AlertDialog.Builder(this)
                .setTitle("Really Exit?")
                .setMessage("Are you sure you want to close the App?")
                .setNegativeButton(android.R.string.no, null)
                .setPositiveButton(android.R.string.yes, new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int which) {
                        finishAffinity();
                    }
                }).create().show();
    }
}