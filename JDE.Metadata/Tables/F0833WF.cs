using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0833WF - .
/// </summary>
public class F0833WF : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WFBSNM.
        /// </summary>
        public const string WFBSNM = "WFBSNM";

        /// <summary>
        /// WFOBNM.
        /// </summary>
        public const string WFOBNM = "WFOBNM";

        /// <summary>
        /// WFAN8.
        /// </summary>
        public const string WFAN8 = "WFAN8";

        /// <summary>
        /// WFMLNM.
        /// </summary>
        public const string WFMLNM = "WFMLNM";

        /// <summary>
        /// WFADD1.
        /// </summary>
        public const string WFADD1 = "WFADD1";

        /// <summary>
        /// WFADD2.
        /// </summary>
        public const string WFADD2 = "WFADD2";

        /// <summary>
        /// WFADD3.
        /// </summary>
        public const string WFADD3 = "WFADD3";

        /// <summary>
        /// WFADD4.
        /// </summary>
        public const string WFADD4 = "WFADD4";

        /// <summary>
        /// WFCTY1.
        /// </summary>
        public const string WFCTY1 = "WFCTY1";

        /// <summary>
        /// WFADDS.
        /// </summary>
        public const string WFADDS = "WFADDS";

        /// <summary>
        /// WFADDZ.
        /// </summary>
        public const string WFADDZ = "WFADDZ";

        /// <summary>
        /// WFCTR.
        /// </summary>
        public const string WFCTR = "WFCTR";

        /// <summary>
        /// WFSAL.
        /// </summary>
        public const string WFSAL = "WFSAL";

        /// <summary>
        /// WFSSN.
        /// </summary>
        public const string WFSSN = "WFSSN";

        /// <summary>
        /// WFDOB.
        /// </summary>
        public const string WFDOB = "WFDOB";

        /// <summary>
        /// WFDST.
        /// </summary>
        public const string WFDST = "WFDST";

        /// <summary>
        /// WFDSI.
        /// </summary>
        public const string WFDSI = "WFDSI";

        /// <summary>
        /// WFHMCU.
        /// </summary>
        public const string WFHMCU = "WFHMCU";

        /// <summary>
        /// WFJBCD.
        /// </summary>
        public const string WFJBCD = "WFJBCD";

        /// <summary>
        /// WFJBST.
        /// </summary>
        public const string WFJBST = "WFJBST";

        /// <summary>
        /// WFHDTY21.
        /// </summary>
        public const string WFHDTY21 = "WFHDTY21";

        /// <summary>
        /// WFHDD21.
        /// </summary>
        public const string WFHDD21 = "WFHDD21";

        /// <summary>
        /// WFEEV01.
        /// </summary>
        public const string WFEEV01 = "WFEEV01";

        /// <summary>
        /// WFERV01.
        /// </summary>
        public const string WFERV01 = "WFERV01";

        /// <summary>
        /// WFHDTY22.
        /// </summary>
        public const string WFHDTY22 = "WFHDTY22";

        /// <summary>
        /// WFHDD22.
        /// </summary>
        public const string WFHDD22 = "WFHDD22";

        /// <summary>
        /// WFEEV02.
        /// </summary>
        public const string WFEEV02 = "WFEEV02";

        /// <summary>
        /// WFERV02.
        /// </summary>
        public const string WFERV02 = "WFERV02";

        /// <summary>
        /// WFHDTY23.
        /// </summary>
        public const string WFHDTY23 = "WFHDTY23";

        /// <summary>
        /// WFHDD23.
        /// </summary>
        public const string WFHDD23 = "WFHDD23";

        /// <summary>
        /// WFEEV03.
        /// </summary>
        public const string WFEEV03 = "WFEEV03";

        /// <summary>
        /// WFERV03.
        /// </summary>
        public const string WFERV03 = "WFERV03";

        /// <summary>
        /// WFHDTY24.
        /// </summary>
        public const string WFHDTY24 = "WFHDTY24";

        /// <summary>
        /// WFHDD24.
        /// </summary>
        public const string WFHDD24 = "WFHDD24";

        /// <summary>
        /// WFEEV04.
        /// </summary>
        public const string WFEEV04 = "WFEEV04";

        /// <summary>
        /// WFERV04.
        /// </summary>
        public const string WFERV04 = "WFERV04";

        /// <summary>
        /// WFHDTY25.
        /// </summary>
        public const string WFHDTY25 = "WFHDTY25";

        /// <summary>
        /// WFHDD25.
        /// </summary>
        public const string WFHDD25 = "WFHDD25";

        /// <summary>
        /// WFEEV05.
        /// </summary>
        public const string WFEEV05 = "WFEEV05";

        /// <summary>
        /// WFERV05.
        /// </summary>
        public const string WFERV05 = "WFERV05";

        /// <summary>
        /// WFHDTY26.
        /// </summary>
        public const string WFHDTY26 = "WFHDTY26";

        /// <summary>
        /// WFHDD26.
        /// </summary>
        public const string WFHDD26 = "WFHDD26";

        /// <summary>
        /// WFEEV06.
        /// </summary>
        public const string WFEEV06 = "WFEEV06";

        /// <summary>
        /// WFERV06.
        /// </summary>
        public const string WFERV06 = "WFERV06";

        /// <summary>
        /// WFHDTY27.
        /// </summary>
        public const string WFHDTY27 = "WFHDTY27";

        /// <summary>
        /// WFHDD27.
        /// </summary>
        public const string WFHDD27 = "WFHDD27";

        /// <summary>
        /// WFEEV07.
        /// </summary>
        public const string WFEEV07 = "WFEEV07";

        /// <summary>
        /// WFERV07.
        /// </summary>
        public const string WFERV07 = "WFERV07";

        /// <summary>
        /// WFHDTY28.
        /// </summary>
        public const string WFHDTY28 = "WFHDTY28";

        /// <summary>
        /// WFHDD28.
        /// </summary>
        public const string WFHDD28 = "WFHDD28";

        /// <summary>
        /// WFEEV08.
        /// </summary>
        public const string WFEEV08 = "WFEEV08";

        /// <summary>
        /// WFERV08.
        /// </summary>
        public const string WFERV08 = "WFERV08";

        /// <summary>
        /// WFHDTY29.
        /// </summary>
        public const string WFHDTY29 = "WFHDTY29";

        /// <summary>
        /// WFHDD29.
        /// </summary>
        public const string WFHDD29 = "WFHDD29";

        /// <summary>
        /// WFEEV09.
        /// </summary>
        public const string WFEEV09 = "WFEEV09";

        /// <summary>
        /// WFERV09.
        /// </summary>
        public const string WFERV09 = "WFERV09";

        /// <summary>
        /// WFHDTY30.
        /// </summary>
        public const string WFHDTY30 = "WFHDTY30";

        /// <summary>
        /// WFHDD30.
        /// </summary>
        public const string WFHDD30 = "WFHDD30";

        /// <summary>
        /// WFEEV10.
        /// </summary>
        public const string WFEEV10 = "WFEEV10";

        /// <summary>
        /// WFERV10.
        /// </summary>
        public const string WFERV10 = "WFERV10";

        /// <summary>
        /// WFHDTY31.
        /// </summary>
        public const string WFHDTY31 = "WFHDTY31";

        /// <summary>
        /// WFHDD31.
        /// </summary>
        public const string WFHDD31 = "WFHDD31";

        /// <summary>
        /// WFEEV11.
        /// </summary>
        public const string WFEEV11 = "WFEEV11";

        /// <summary>
        /// WFERV11.
        /// </summary>
        public const string WFERV11 = "WFERV11";

        /// <summary>
        /// WFHDTY32.
        /// </summary>
        public const string WFHDTY32 = "WFHDTY32";

        /// <summary>
        /// WFHDD32.
        /// </summary>
        public const string WFHDD32 = "WFHDD32";

        /// <summary>
        /// WFEEV12.
        /// </summary>
        public const string WFEEV12 = "WFEEV12";

        /// <summary>
        /// WFERV12.
        /// </summary>
        public const string WFERV12 = "WFERV12";

        /// <summary>
        /// WFHDTY33.
        /// </summary>
        public const string WFHDTY33 = "WFHDTY33";

        /// <summary>
        /// WFHDD33.
        /// </summary>
        public const string WFHDD33 = "WFHDD33";

        /// <summary>
        /// WFEEV13.
        /// </summary>
        public const string WFEEV13 = "WFEEV13";

        /// <summary>
        /// WFERV13.
        /// </summary>
        public const string WFERV13 = "WFERV13";

        /// <summary>
        /// WFHDTY34.
        /// </summary>
        public const string WFHDTY34 = "WFHDTY34";

        /// <summary>
        /// WFHDD34.
        /// </summary>
        public const string WFHDD34 = "WFHDD34";

        /// <summary>
        /// WFEEV14.
        /// </summary>
        public const string WFEEV14 = "WFEEV14";

        /// <summary>
        /// WFERV14.
        /// </summary>
        public const string WFERV14 = "WFERV14";

        /// <summary>
        /// WFHDTY35.
        /// </summary>
        public const string WFHDTY35 = "WFHDTY35";

        /// <summary>
        /// WFHDD35.
        /// </summary>
        public const string WFHDD35 = "WFHDD35";

        /// <summary>
        /// WFEEV15.
        /// </summary>
        public const string WFEEV15 = "WFEEV15";

        /// <summary>
        /// WFERV15.
        /// </summary>
        public const string WFERV15 = "WFERV15";

        /// <summary>
        /// WFHDTY01.
        /// </summary>
        public const string WFHDTY01 = "WFHDTY01";

        /// <summary>
        /// WFHDD01.
        /// </summary>
        public const string WFHDD01 = "WFHDD01";

        /// <summary>
        /// WFEEV21.
        /// </summary>
        public const string WFEEV21 = "WFEEV21";

        /// <summary>
        /// WFERV21.
        /// </summary>
        public const string WFERV21 = "WFERV21";

        /// <summary>
        /// WFHDTY02.
        /// </summary>
        public const string WFHDTY02 = "WFHDTY02";

        /// <summary>
        /// WFHDD02.
        /// </summary>
        public const string WFHDD02 = "WFHDD02";

        /// <summary>
        /// WFEEV22.
        /// </summary>
        public const string WFEEV22 = "WFEEV22";

        /// <summary>
        /// WFERV22.
        /// </summary>
        public const string WFERV22 = "WFERV22";

        /// <summary>
        /// WFHDTY03.
        /// </summary>
        public const string WFHDTY03 = "WFHDTY03";

        /// <summary>
        /// WFHDD03.
        /// </summary>
        public const string WFHDD03 = "WFHDD03";

        /// <summary>
        /// WFEEV23.
        /// </summary>
        public const string WFEEV23 = "WFEEV23";

        /// <summary>
        /// WFERV23.
        /// </summary>
        public const string WFERV23 = "WFERV23";

        /// <summary>
        /// WFHDTY04.
        /// </summary>
        public const string WFHDTY04 = "WFHDTY04";

        /// <summary>
        /// WFHDD04.
        /// </summary>
        public const string WFHDD04 = "WFHDD04";

        /// <summary>
        /// WFEEV24.
        /// </summary>
        public const string WFEEV24 = "WFEEV24";

        /// <summary>
        /// WFERV24.
        /// </summary>
        public const string WFERV24 = "WFERV24";

        /// <summary>
        /// WFHDTY05.
        /// </summary>
        public const string WFHDTY05 = "WFHDTY05";

        /// <summary>
        /// WFHDD05.
        /// </summary>
        public const string WFHDD05 = "WFHDD05";

        /// <summary>
        /// WFEEV25.
        /// </summary>
        public const string WFEEV25 = "WFEEV25";

        /// <summary>
        /// WFERV25.
        /// </summary>
        public const string WFERV25 = "WFERV25";

        /// <summary>
        /// WFHDTY06.
        /// </summary>
        public const string WFHDTY06 = "WFHDTY06";

        /// <summary>
        /// WFHDD06.
        /// </summary>
        public const string WFHDD06 = "WFHDD06";

        /// <summary>
        /// WFEEV26.
        /// </summary>
        public const string WFEEV26 = "WFEEV26";

        /// <summary>
        /// WFERV26.
        /// </summary>
        public const string WFERV26 = "WFERV26";

        /// <summary>
        /// WFHDTY07.
        /// </summary>
        public const string WFHDTY07 = "WFHDTY07";

        /// <summary>
        /// WFHDD07.
        /// </summary>
        public const string WFHDD07 = "WFHDD07";

        /// <summary>
        /// WFEEV27.
        /// </summary>
        public const string WFEEV27 = "WFEEV27";

        /// <summary>
        /// WFERV27.
        /// </summary>
        public const string WFERV27 = "WFERV27";

        /// <summary>
        /// WFHDTY08.
        /// </summary>
        public const string WFHDTY08 = "WFHDTY08";

        /// <summary>
        /// WFHDD08.
        /// </summary>
        public const string WFHDD08 = "WFHDD08";

        /// <summary>
        /// WFEEV28.
        /// </summary>
        public const string WFEEV28 = "WFEEV28";

        /// <summary>
        /// WFERV28.
        /// </summary>
        public const string WFERV28 = "WFERV28";

        /// <summary>
        /// WFHDTY09.
        /// </summary>
        public const string WFHDTY09 = "WFHDTY09";

        /// <summary>
        /// WFHDD09.
        /// </summary>
        public const string WFHDD09 = "WFHDD09";

        /// <summary>
        /// WFEEV29.
        /// </summary>
        public const string WFEEV29 = "WFEEV29";

        /// <summary>
        /// WFERV29.
        /// </summary>
        public const string WFERV29 = "WFERV29";

        /// <summary>
        /// WFHDTY10.
        /// </summary>
        public const string WFHDTY10 = "WFHDTY10";

        /// <summary>
        /// WFHDD10.
        /// </summary>
        public const string WFHDD10 = "WFHDD10";

        /// <summary>
        /// WFEEV30.
        /// </summary>
        public const string WFEEV30 = "WFEEV30";

        /// <summary>
        /// WFERV30.
        /// </summary>
        public const string WFERV30 = "WFERV30";

        /// <summary>
        /// WFHDTY11.
        /// </summary>
        public const string WFHDTY11 = "WFHDTY11";

        /// <summary>
        /// WFHDD11.
        /// </summary>
        public const string WFHDD11 = "WFHDD11";

        /// <summary>
        /// WFEEV31.
        /// </summary>
        public const string WFEEV31 = "WFEEV31";

        /// <summary>
        /// WFERV31.
        /// </summary>
        public const string WFERV31 = "WFERV31";

        /// <summary>
        /// WFHDTY12.
        /// </summary>
        public const string WFHDTY12 = "WFHDTY12";

        /// <summary>
        /// WFHDD12.
        /// </summary>
        public const string WFHDD12 = "WFHDD12";

        /// <summary>
        /// WFEEV32.
        /// </summary>
        public const string WFEEV32 = "WFEEV32";

        /// <summary>
        /// WFERV32.
        /// </summary>
        public const string WFERV32 = "WFERV32";

        /// <summary>
        /// WFHDTY13.
        /// </summary>
        public const string WFHDTY13 = "WFHDTY13";

        /// <summary>
        /// WFHDD13.
        /// </summary>
        public const string WFHDD13 = "WFHDD13";

        /// <summary>
        /// WFEEV33.
        /// </summary>
        public const string WFEEV33 = "WFEEV33";

        /// <summary>
        /// WFERV33.
        /// </summary>
        public const string WFERV33 = "WFERV33";

        /// <summary>
        /// WFHDTY14.
        /// </summary>
        public const string WFHDTY14 = "WFHDTY14";

        /// <summary>
        /// WFHDD14.
        /// </summary>
        public const string WFHDD14 = "WFHDD14";

        /// <summary>
        /// WFEEV34.
        /// </summary>
        public const string WFEEV34 = "WFEEV34";

        /// <summary>
        /// WFERV34.
        /// </summary>
        public const string WFERV34 = "WFERV34";

        /// <summary>
        /// WFHDTY15.
        /// </summary>
        public const string WFHDTY15 = "WFHDTY15";

        /// <summary>
        /// WFHDD15.
        /// </summary>
        public const string WFHDD15 = "WFHDD15";

        /// <summary>
        /// WFEEV35.
        /// </summary>
        public const string WFEEV35 = "WFEEV35";

        /// <summary>
        /// WFERV35.
        /// </summary>
        public const string WFERV35 = "WFERV35";

        /// <summary>
        /// WFEEV41.
        /// </summary>
        public const string WFEEV41 = "WFEEV41";

        /// <summary>
        /// WFERV41.
        /// </summary>
        public const string WFERV41 = "WFERV41";

        /// <summary>
        /// WFEEV42.
        /// </summary>
        public const string WFEEV42 = "WFEEV42";

        /// <summary>
        /// WFERV42.
        /// </summary>
        public const string WFERV42 = "WFERV42";

        /// <summary>
        /// WFMATH01.
        /// </summary>
        public const string WFMATH01 = "WFMATH01";

        /// <summary>
        /// WFMATH02.
        /// </summary>
        public const string WFMATH02 = "WFMATH02";

        /// <summary>
        /// WFMATH03.
        /// </summary>
        public const string WFMATH03 = "WFMATH03";

        /// <summary>
        /// WFMATH04.
        /// </summary>
        public const string WFMATH04 = "WFMATH04";

        /// <summary>
        /// WFMATH05.
        /// </summary>
        public const string WFMATH05 = "WFMATH05";

        /// <summary>
        /// WFMATH06.
        /// </summary>
        public const string WFMATH06 = "WFMATH06";

        /// <summary>
        /// WFUSER.
        /// </summary>
        public const string WFUSER = "WFUSER";

        /// <summary>
        /// WFPID.
        /// </summary>
        public const string WFPID = "WFPID";

        /// <summary>
        /// WFUPMJ.
        /// </summary>
        public const string WFUPMJ = "WFUPMJ";

        /// <summary>
        /// WFJOBN.
        /// </summary>
        public const string WFJOBN = "WFJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F0833WF";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WFBSNM", "WFBSNM", JdeDataType.String, 20, true, true),
        new JdeField("WFOBNM", "WFOBNM", JdeDataType.String, 20),
        new JdeField("WFAN8", "WFAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("WFMLNM", "WFMLNM", JdeDataType.String, 80),
        new JdeField("WFADD1", "WFADD1", JdeDataType.String, 80),
        new JdeField("WFADD2", "WFADD2", JdeDataType.String, 80),
        new JdeField("WFADD3", "WFADD3", JdeDataType.String, 80),
        new JdeField("WFADD4", "WFADD4", JdeDataType.String, 80),
        new JdeField("WFCTY1", "WFCTY1", JdeDataType.String, 50),
        new JdeField("WFADDS", "WFADDS", JdeDataType.String, 6),
        new JdeField("WFADDZ", "WFADDZ", JdeDataType.String, 24),
        new JdeField("WFCTR", "WFCTR", JdeDataType.String, 6),
        new JdeField("WFSAL", "WFSAL", JdeDataType.Numeric),
        new JdeField("WFSSN", "WFSSN", JdeDataType.String, 40),
        new JdeField("WFDOB", "WFDOB", JdeDataType.Numeric),
        new JdeField("WFDST", "WFDST", JdeDataType.Numeric),
        new JdeField("WFDSI", "WFDSI", JdeDataType.Numeric),
        new JdeField("WFHMCU", "WFHMCU", JdeDataType.String, 24),
        new JdeField("WFJBCD", "WFJBCD", JdeDataType.String, 12),
        new JdeField("WFJBST", "WFJBST", JdeDataType.String, 8),
        new JdeField("WFHDTY21", "WFHDTY21", JdeDataType.String, 2),
        new JdeField("WFHDD21", "WFHDD21", JdeDataType.String, 40),
        new JdeField("WFEEV01", "WFEEV01", JdeDataType.Numeric),
        new JdeField("WFERV01", "WFERV01", JdeDataType.Numeric),
        new JdeField("WFHDTY22", "WFHDTY22", JdeDataType.String, 2),
        new JdeField("WFHDD22", "WFHDD22", JdeDataType.String, 60),
        new JdeField("WFEEV02", "WFEEV02", JdeDataType.Numeric),
        new JdeField("WFERV02", "WFERV02", JdeDataType.Numeric),
        new JdeField("WFHDTY23", "WFHDTY23", JdeDataType.String, 2),
        new JdeField("WFHDD23", "WFHDD23", JdeDataType.String, 60),
        new JdeField("WFEEV03", "WFEEV03", JdeDataType.Numeric),
        new JdeField("WFERV03", "WFERV03", JdeDataType.Numeric),
        new JdeField("WFHDTY24", "WFHDTY24", JdeDataType.String, 2),
        new JdeField("WFHDD24", "WFHDD24", JdeDataType.String, 60),
        new JdeField("WFEEV04", "WFEEV04", JdeDataType.Numeric),
        new JdeField("WFERV04", "WFERV04", JdeDataType.Numeric),
        new JdeField("WFHDTY25", "WFHDTY25", JdeDataType.String, 2),
        new JdeField("WFHDD25", "WFHDD25", JdeDataType.String, 60),
        new JdeField("WFEEV05", "WFEEV05", JdeDataType.Numeric),
        new JdeField("WFERV05", "WFERV05", JdeDataType.Numeric),
        new JdeField("WFHDTY26", "WFHDTY26", JdeDataType.String, 2),
        new JdeField("WFHDD26", "WFHDD26", JdeDataType.String, 60),
        new JdeField("WFEEV06", "WFEEV06", JdeDataType.Numeric),
        new JdeField("WFERV06", "WFERV06", JdeDataType.Numeric),
        new JdeField("WFHDTY27", "WFHDTY27", JdeDataType.String, 2),
        new JdeField("WFHDD27", "WFHDD27", JdeDataType.String, 60),
        new JdeField("WFEEV07", "WFEEV07", JdeDataType.Numeric),
        new JdeField("WFERV07", "WFERV07", JdeDataType.Numeric),
        new JdeField("WFHDTY28", "WFHDTY28", JdeDataType.String, 2),
        new JdeField("WFHDD28", "WFHDD28", JdeDataType.String, 60),
        new JdeField("WFEEV08", "WFEEV08", JdeDataType.Numeric),
        new JdeField("WFERV08", "WFERV08", JdeDataType.Numeric),
        new JdeField("WFHDTY29", "WFHDTY29", JdeDataType.String, 2),
        new JdeField("WFHDD29", "WFHDD29", JdeDataType.String, 60),
        new JdeField("WFEEV09", "WFEEV09", JdeDataType.Numeric),
        new JdeField("WFERV09", "WFERV09", JdeDataType.Numeric),
        new JdeField("WFHDTY30", "WFHDTY30", JdeDataType.String, 2),
        new JdeField("WFHDD30", "WFHDD30", JdeDataType.String, 60),
        new JdeField("WFEEV10", "WFEEV10", JdeDataType.Numeric),
        new JdeField("WFERV10", "WFERV10", JdeDataType.Numeric),
        new JdeField("WFHDTY31", "WFHDTY31", JdeDataType.String, 2),
        new JdeField("WFHDD31", "WFHDD31", JdeDataType.String, 60),
        new JdeField("WFEEV11", "WFEEV11", JdeDataType.Numeric),
        new JdeField("WFERV11", "WFERV11", JdeDataType.Numeric),
        new JdeField("WFHDTY32", "WFHDTY32", JdeDataType.String, 2),
        new JdeField("WFHDD32", "WFHDD32", JdeDataType.String, 60),
        new JdeField("WFEEV12", "WFEEV12", JdeDataType.Numeric),
        new JdeField("WFERV12", "WFERV12", JdeDataType.Numeric),
        new JdeField("WFHDTY33", "WFHDTY33", JdeDataType.String, 2),
        new JdeField("WFHDD33", "WFHDD33", JdeDataType.String, 60),
        new JdeField("WFEEV13", "WFEEV13", JdeDataType.Numeric),
        new JdeField("WFERV13", "WFERV13", JdeDataType.Numeric),
        new JdeField("WFHDTY34", "WFHDTY34", JdeDataType.String, 2),
        new JdeField("WFHDD34", "WFHDD34", JdeDataType.String, 60),
        new JdeField("WFEEV14", "WFEEV14", JdeDataType.Numeric),
        new JdeField("WFERV14", "WFERV14", JdeDataType.Numeric),
        new JdeField("WFHDTY35", "WFHDTY35", JdeDataType.String, 2),
        new JdeField("WFHDD35", "WFHDD35", JdeDataType.String, 60),
        new JdeField("WFEEV15", "WFEEV15", JdeDataType.Numeric),
        new JdeField("WFERV15", "WFERV15", JdeDataType.Numeric),
        new JdeField("WFHDTY01", "WFHDTY01", JdeDataType.String, 2),
        new JdeField("WFHDD01", "WFHDD01", JdeDataType.String, 60),
        new JdeField("WFEEV21", "WFEEV21", JdeDataType.Numeric),
        new JdeField("WFERV21", "WFERV21", JdeDataType.Numeric),
        new JdeField("WFHDTY02", "WFHDTY02", JdeDataType.String, 2),
        new JdeField("WFHDD02", "WFHDD02", JdeDataType.String, 60),
        new JdeField("WFEEV22", "WFEEV22", JdeDataType.Numeric),
        new JdeField("WFERV22", "WFERV22", JdeDataType.Numeric),
        new JdeField("WFHDTY03", "WFHDTY03", JdeDataType.String, 2),
        new JdeField("WFHDD03", "WFHDD03", JdeDataType.String, 60),
        new JdeField("WFEEV23", "WFEEV23", JdeDataType.Numeric),
        new JdeField("WFERV23", "WFERV23", JdeDataType.Numeric),
        new JdeField("WFHDTY04", "WFHDTY04", JdeDataType.String, 2),
        new JdeField("WFHDD04", "WFHDD04", JdeDataType.String, 60),
        new JdeField("WFEEV24", "WFEEV24", JdeDataType.Numeric),
        new JdeField("WFERV24", "WFERV24", JdeDataType.Numeric),
        new JdeField("WFHDTY05", "WFHDTY05", JdeDataType.String, 2),
        new JdeField("WFHDD05", "WFHDD05", JdeDataType.String, 60),
        new JdeField("WFEEV25", "WFEEV25", JdeDataType.Numeric),
        new JdeField("WFERV25", "WFERV25", JdeDataType.Numeric),
        new JdeField("WFHDTY06", "WFHDTY06", JdeDataType.String, 2),
        new JdeField("WFHDD06", "WFHDD06", JdeDataType.String, 60),
        new JdeField("WFEEV26", "WFEEV26", JdeDataType.Numeric),
        new JdeField("WFERV26", "WFERV26", JdeDataType.Numeric),
        new JdeField("WFHDTY07", "WFHDTY07", JdeDataType.String, 2),
        new JdeField("WFHDD07", "WFHDD07", JdeDataType.String, 60),
        new JdeField("WFEEV27", "WFEEV27", JdeDataType.Numeric),
        new JdeField("WFERV27", "WFERV27", JdeDataType.Numeric),
        new JdeField("WFHDTY08", "WFHDTY08", JdeDataType.String, 2),
        new JdeField("WFHDD08", "WFHDD08", JdeDataType.String, 60),
        new JdeField("WFEEV28", "WFEEV28", JdeDataType.Numeric),
        new JdeField("WFERV28", "WFERV28", JdeDataType.Numeric),
        new JdeField("WFHDTY09", "WFHDTY09", JdeDataType.String, 2),
        new JdeField("WFHDD09", "WFHDD09", JdeDataType.String, 60),
        new JdeField("WFEEV29", "WFEEV29", JdeDataType.Numeric),
        new JdeField("WFERV29", "WFERV29", JdeDataType.Numeric),
        new JdeField("WFHDTY10", "WFHDTY10", JdeDataType.String, 2),
        new JdeField("WFHDD10", "WFHDD10", JdeDataType.String, 60),
        new JdeField("WFEEV30", "WFEEV30", JdeDataType.Numeric),
        new JdeField("WFERV30", "WFERV30", JdeDataType.Numeric),
        new JdeField("WFHDTY11", "WFHDTY11", JdeDataType.String, 2),
        new JdeField("WFHDD11", "WFHDD11", JdeDataType.String, 60),
        new JdeField("WFEEV31", "WFEEV31", JdeDataType.Numeric),
        new JdeField("WFERV31", "WFERV31", JdeDataType.Numeric),
        new JdeField("WFHDTY12", "WFHDTY12", JdeDataType.String, 2),
        new JdeField("WFHDD12", "WFHDD12", JdeDataType.String, 60),
        new JdeField("WFEEV32", "WFEEV32", JdeDataType.Numeric),
        new JdeField("WFERV32", "WFERV32", JdeDataType.Numeric),
        new JdeField("WFHDTY13", "WFHDTY13", JdeDataType.String, 2),
        new JdeField("WFHDD13", "WFHDD13", JdeDataType.String, 60),
        new JdeField("WFEEV33", "WFEEV33", JdeDataType.Numeric),
        new JdeField("WFERV33", "WFERV33", JdeDataType.Numeric),
        new JdeField("WFHDTY14", "WFHDTY14", JdeDataType.String, 2),
        new JdeField("WFHDD14", "WFHDD14", JdeDataType.String, 60),
        new JdeField("WFEEV34", "WFEEV34", JdeDataType.Numeric),
        new JdeField("WFERV34", "WFERV34", JdeDataType.Numeric),
        new JdeField("WFHDTY15", "WFHDTY15", JdeDataType.String, 2),
        new JdeField("WFHDD15", "WFHDD15", JdeDataType.String, 60),
        new JdeField("WFEEV35", "WFEEV35", JdeDataType.Numeric),
        new JdeField("WFERV35", "WFERV35", JdeDataType.Numeric),
        new JdeField("WFEEV41", "WFEEV41", JdeDataType.Numeric),
        new JdeField("WFERV41", "WFERV41", JdeDataType.Numeric),
        new JdeField("WFEEV42", "WFEEV42", JdeDataType.Numeric),
        new JdeField("WFERV42", "WFERV42", JdeDataType.Numeric),
        new JdeField("WFMATH01", "WFMATH01", JdeDataType.Numeric),
        new JdeField("WFMATH02", "WFMATH02", JdeDataType.Numeric),
        new JdeField("WFMATH03", "WFMATH03", JdeDataType.Numeric),
        new JdeField("WFMATH04", "WFMATH04", JdeDataType.Numeric),
        new JdeField("WFMATH05", "WFMATH05", JdeDataType.Numeric),
        new JdeField("WFMATH06", "WFMATH06", JdeDataType.Numeric),
        new JdeField("WFUSER", "WFUSER", JdeDataType.String, 20),
        new JdeField("WFPID", "WFPID", JdeDataType.String, 20),
        new JdeField("WFUPMJ", "WFUPMJ", JdeDataType.Numeric),
        new JdeField("WFJOBN", "WFJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0833WF_0", "Primary Key on WFBSNM, WFAN8", new[] { "WFBSNM", "WFAN8" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0833WF_2", "Index on WFBSNM, WFMATH06", new[] { "WFBSNM", "WFMATH06" })
    };
}
