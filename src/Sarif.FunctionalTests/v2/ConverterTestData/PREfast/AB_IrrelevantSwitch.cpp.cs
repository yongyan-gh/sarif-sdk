<?xml version="1.0" encoding="UTF-8"?>
<DEFECTS>
  <DEFECT>
    <SFA>
      <FILEPATH>d:\src\sarif-sdk\src\sarif.functionaltests\convertertestdata\prefast\src\advancedbranches\</FILEPATH>
      <FILENAME>ab_irrelevantswitch.cpp</FILENAME>
      <LINE>30</LINE>
      <COLUMN>5</COLUMN>
    </SFA>
    <DEFECTCODE>6385</DEFECTCODE>
    <DESCRIPTION>Reading invalid data from 'data':  the readable size is '8' bytes, but '12' bytes may be read.</DESCRIPTION>
    <FUNCTION>C6385_MaybeRelevantSwitch</FUNCTION>
    <DECORATED>?C6385_MaybeRelevantSwitch@@YAXH_N@Z</DECORATED>
    <FUNCLINE>9</FUNCLINE>
    <PROBABILITY>1</PROBABILITY>
    <RANK>4</RANK>
    <CATEGORY>
      <RULECATEGORY>mspft</RULECATEGORY>
    </CATEGORY>
    <PATH>
      <SFA>
        <FILEPATH>d:\src\sarif-sdk\src\sarif.functionaltests\convertertestdata\prefast\src\advancedbranches\</FILEPATH>
        <FILENAME>ab_irrelevantswitch.cpp</FILENAME>
        <LINE>11</LINE>
        <COLUMN>5</COLUMN>
        <KEYEVENT>
          <ID>1</ID>
          <KIND>declaration</KIND>
          <IMPORTANCE>Essential</IMPORTANCE>
          <MESSAGE>'data' is an array of 2 elements (8 bytes)</MESSAGE>
        </KEYEVENT>
      </SFA>
      <SFA>
        <FILEPATH>d:\src\sarif-sdk\src\sarif.functionaltests\convertertestdata\prefast\src\advancedbranches\</FILEPATH>
        <FILENAME>ab_irrelevantswitch.cpp</FILENAME>
        <LINE>12</LINE>
        <COLUMN>9</COLUMN>
      </SFA>
      <SFA>
        <FILEPATH>d:\src\sarif-sdk\src\sarif.functionaltests\convertertestdata\prefast\src\advancedbranches\</FILEPATH>
        <FILENAME>ab_irrelevantswitch.cpp</FILENAME>
        <LINE>12</LINE>
        <COLUMN>22</COLUMN>
      </SFA>
      <SFA>
        <FILEPATH>d:\src\sarif-sdk\src\sarif.functionaltests\convertertestdata\prefast\src\advancedbranches\</FILEPATH>
        <FILENAME>ab_irrelevantswitch.cpp</FILENAME>
        <LINE>14</LINE>
        <COLUMN>5</COLUMN>
        <KEYEVENT>
          <ID>2</ID>
          <KIND>declaration</KIND>
          <IMPORTANCE>Essential</IMPORTANCE>
          <MESSAGE>'index' is equal to 2</MESSAGE>
        </KEYEVENT>
      </SFA>
      <SFA>
        <FILEPATH>d:\src\sarif-sdk\src\sarif.functionaltests\convertertestdata\prefast\src\advancedbranches\</FILEPATH>
        <FILENAME>ab_irrelevantswitch.cpp</FILENAME>
        <LINE>16</LINE>
        <COLUMN>8</COLUMN>
        <KEYEVENT>
          <ID>3</ID>
          <KIND>branch</KIND>
          <IMPORTANCE>Full</IMPORTANCE>
          <MESSAGE>Assume switch ( 'flag' ) resolves to case 1: </MESSAGE>
        </KEYEVENT>
      </SFA>
      <SFA>
        <FILEPATH>d:\src\sarif-sdk\src\sarif.functionaltests\convertertestdata\prefast\src\advancedbranches\</FILEPATH>
        <FILENAME>ab_irrelevantswitch.cpp</FILENAME>
        <LINE>18</LINE>
        <COLUMN>1</COLUMN>
      </SFA>
      <SFA>
        <FILEPATH>d:\src\sarif-sdk\src\sarif.functionaltests\convertertestdata\prefast\src\advancedbranches\</FILEPATH>
        <FILENAME>ab_irrelevantswitch.cpp</FILENAME>
        <LINE>30</LINE>
        <COLUMN>5</COLUMN>
        <KEYEVENT>
          <ID>4</ID>
          <KIND>usage</KIND>
          <IMPORTANCE>Essential</IMPORTANCE>
          <MESSAGE>Invalid read from 'data[2]', (readable range is 0 to 1)</MESSAGE>
        </KEYEVENT>
      </SFA>
    </PATH>
  </DEFECT>
</DEFECTS>