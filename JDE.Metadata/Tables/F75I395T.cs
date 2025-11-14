using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I395T - .
/// </summary>
public class F75I395T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ERITMR.
        /// </summary>
        public const string ERITMR = "ERITMR";

        /// <summary>
        /// ERKITA.
        /// </summary>
        public const string ERKITA = "ERKITA";

        /// <summary>
        /// ERKIT.
        /// </summary>
        public const string ERKIT = "ERKIT";

        /// <summary>
        /// ERKITL.
        /// </summary>
        public const string ERKITL = "ERKITL";

        /// <summary>
        /// ERDL01.
        /// </summary>
        public const string ERDL01 = "ERDL01";

        /// <summary>
        /// ERMMCU.
        /// </summary>
        public const string ERMMCU = "ERMMCU";

        /// <summary>
        /// ERUOM.
        /// </summary>
        public const string ERUOM = "ERUOM";

        /// <summary>
        /// ERCHAPTER.
        /// </summary>
        public const string ERCHAPTER = "ERCHAPTER";

        /// <summary>
        /// ERITM.
        /// </summary>
        public const string ERITM = "ERITM";

        /// <summary>
        /// ERDSC1.
        /// </summary>
        public const string ERDSC1 = "ERDSC1";

        /// <summary>
        /// ERLITM.
        /// </summary>
        public const string ERLITM = "ERLITM";

        /// <summary>
        /// ERCMCU.
        /// </summary>
        public const string ERCMCU = "ERCMCU";

        /// <summary>
        /// ERUM.
        /// </summary>
        public const string ERUM = "ERUM";

        /// <summary>
        /// ERYCHN.
        /// </summary>
        public const string ERYCHN = "ERYCHN";

        /// <summary>
        /// ERSTKT.
        /// </summary>
        public const string ERSTKT = "ERSTKT";

        /// <summary>
        /// ERSTRX.
        /// </summary>
        public const string ERSTRX = "ERSTRX";

        /// <summary>
        /// ERFLG.
        /// </summary>
        public const string ERFLG = "ERFLG";

        /// <summary>
        /// ERQNTY.
        /// </summary>
        public const string ERQNTY = "ERQNTY";

        /// <summary>
        /// ERBQTY.
        /// </summary>
        public const string ERBQTY = "ERBQTY";

        /// <summary>
        /// ERMUNT.
        /// </summary>
        public const string ERMUNT = "ERMUNT";

        /// <summary>
        /// ERLOTN.
        /// </summary>
        public const string ERLOTN = "ERLOTN";

        /// <summary>
        /// ERYQTY.
        /// </summary>
        public const string ERYQTY = "ERYQTY";

        /// <summary>
        /// ERCRAOW.
        /// </summary>
        public const string ERCRAOW = "ERCRAOW";

        /// <summary>
        /// ERUNCS.
        /// </summary>
        public const string ERUNCS = "ERUNCS";

        /// <summary>
        /// ERNCST.
        /// </summary>
        public const string ERNCST = "ERNCST";

        /// <summary>
        /// ERMATH01.
        /// </summary>
        public const string ERMATH01 = "ERMATH01";

        /// <summary>
        /// ERMATH02.
        /// </summary>
        public const string ERMATH02 = "ERMATH02";

        /// <summary>
        /// ERMATH03.
        /// </summary>
        public const string ERMATH03 = "ERMATH03";

        /// <summary>
        /// ERMATH04.
        /// </summary>
        public const string ERMATH04 = "ERMATH04";

        /// <summary>
        /// ERMATH05.
        /// </summary>
        public const string ERMATH05 = "ERMATH05";

        /// <summary>
        /// ERYFUTDT1.
        /// </summary>
        public const string ERYFUTDT1 = "ERYFUTDT1";

        /// <summary>
        /// ERYFUTDT2.
        /// </summary>
        public const string ERYFUTDT2 = "ERYFUTDT2";

        /// <summary>
        /// ERYFUTDT3.
        /// </summary>
        public const string ERYFUTDT3 = "ERYFUTDT3";

        /// <summary>
        /// ERYFUTDT4.
        /// </summary>
        public const string ERYFUTDT4 = "ERYFUTDT4";

        /// <summary>
        /// ERYFUTDT5.
        /// </summary>
        public const string ERYFUTDT5 = "ERYFUTDT5";

        /// <summary>
        /// ERYFUSTR1.
        /// </summary>
        public const string ERYFUSTR1 = "ERYFUSTR1";

        /// <summary>
        /// ERYFUSTR2.
        /// </summary>
        public const string ERYFUSTR2 = "ERYFUSTR2";

        /// <summary>
        /// ERYFUSTR3.
        /// </summary>
        public const string ERYFUSTR3 = "ERYFUSTR3";

        /// <summary>
        /// ERYFUSTR4.
        /// </summary>
        public const string ERYFUSTR4 = "ERYFUSTR4";

        /// <summary>
        /// ERYFUSTR5.
        /// </summary>
        public const string ERYFUSTR5 = "ERYFUSTR5";

        /// <summary>
        /// ERYT04.
        /// </summary>
        public const string ERYT04 = "ERYT04";

        /// <summary>
        /// ERYT05.
        /// </summary>
        public const string ERYT05 = "ERYT05";

        /// <summary>
        /// ERYT06.
        /// </summary>
        public const string ERYT06 = "ERYT06";

        /// <summary>
        /// ERYT07.
        /// </summary>
        public const string ERYT07 = "ERYT07";

        /// <summary>
        /// ERYT08.
        /// </summary>
        public const string ERYT08 = "ERYT08";

        /// <summary>
        /// ERYFUAMT1.
        /// </summary>
        public const string ERYFUAMT1 = "ERYFUAMT1";

        /// <summary>
        /// ERYFUQTY2.
        /// </summary>
        public const string ERYFUQTY2 = "ERYFUQTY2";

        /// <summary>
        /// ERYFUQTY3.
        /// </summary>
        public const string ERYFUQTY3 = "ERYFUQTY3";

        /// <summary>
        /// ERYFUQTY4.
        /// </summary>
        public const string ERYFUQTY4 = "ERYFUQTY4";

        /// <summary>
        /// ERUSER.
        /// </summary>
        public const string ERUSER = "ERUSER";

        /// <summary>
        /// ERJOBN.
        /// </summary>
        public const string ERJOBN = "ERJOBN";

        /// <summary>
        /// ERPID.
        /// </summary>
        public const string ERPID = "ERPID";

        /// <summary>
        /// ERUPMJ.
        /// </summary>
        public const string ERUPMJ = "ERUPMJ";

        /// <summary>
        /// ERUPMT.
        /// </summary>
        public const string ERUPMT = "ERUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75I395T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ERITMR", "ERITMR", JdeDataType.Numeric, null, true, true),
        new JdeField("ERKITA", "ERKITA", JdeDataType.String, 50),
        new JdeField("ERKIT", "ERKIT", JdeDataType.Numeric, null, true, true),
        new JdeField("ERKITL", "ERKITL", JdeDataType.String, 50),
        new JdeField("ERDL01", "ERDL01", JdeDataType.String, 60),
        new JdeField("ERMMCU", "ERMMCU", JdeDataType.String, 24),
        new JdeField("ERUOM", "ERUOM", JdeDataType.String, 4),
        new JdeField("ERCHAPTER", "ERCHAPTER", JdeDataType.String, 20),
        new JdeField("ERITM", "ERITM", JdeDataType.Numeric, null, true, true),
        new JdeField("ERDSC1", "ERDSC1", JdeDataType.String, 60),
        new JdeField("ERLITM", "ERLITM", JdeDataType.String, 50),
        new JdeField("ERCMCU", "ERCMCU", JdeDataType.String, 24),
        new JdeField("ERUM", "ERUM", JdeDataType.String, 4),
        new JdeField("ERYCHN", "ERYCHN", JdeDataType.String, 40),
        new JdeField("ERSTKT", "ERSTKT", JdeDataType.String, 2, true, true),
        new JdeField("ERSTRX", "ERSTRX", JdeDataType.Numeric, null, true, true),
        new JdeField("ERFLG", "ERFLG", JdeDataType.String, 2),
        new JdeField("ERQNTY", "ERQNTY", JdeDataType.Numeric),
        new JdeField("ERBQTY", "ERBQTY", JdeDataType.Numeric),
        new JdeField("ERMUNT", "ERMUNT", JdeDataType.Numeric),
        new JdeField("ERLOTN", "ERLOTN", JdeDataType.String, 60),
        new JdeField("ERYQTY", "ERYQTY", JdeDataType.Numeric),
        new JdeField("ERCRAOW", "ERCRAOW", JdeDataType.Numeric),
        new JdeField("ERUNCS", "ERUNCS", JdeDataType.Numeric),
        new JdeField("ERNCST", "ERNCST", JdeDataType.Numeric),
        new JdeField("ERMATH01", "ERMATH01", JdeDataType.Numeric),
        new JdeField("ERMATH02", "ERMATH02", JdeDataType.Numeric),
        new JdeField("ERMATH03", "ERMATH03", JdeDataType.Numeric),
        new JdeField("ERMATH04", "ERMATH04", JdeDataType.Numeric),
        new JdeField("ERMATH05", "ERMATH05", JdeDataType.Numeric),
        new JdeField("ERYFUTDT1", "ERYFUTDT1", JdeDataType.Numeric),
        new JdeField("ERYFUTDT2", "ERYFUTDT2", JdeDataType.Numeric),
        new JdeField("ERYFUTDT3", "ERYFUTDT3", JdeDataType.Numeric),
        new JdeField("ERYFUTDT4", "ERYFUTDT4", JdeDataType.Numeric),
        new JdeField("ERYFUTDT5", "ERYFUTDT5", JdeDataType.Numeric),
        new JdeField("ERYFUSTR1", "ERYFUSTR1", JdeDataType.String, 60),
        new JdeField("ERYFUSTR2", "ERYFUSTR2", JdeDataType.String, 60),
        new JdeField("ERYFUSTR3", "ERYFUSTR3", JdeDataType.String, 60),
        new JdeField("ERYFUSTR4", "ERYFUSTR4", JdeDataType.String, 60),
        new JdeField("ERYFUSTR5", "ERYFUSTR5", JdeDataType.String, 60),
        new JdeField("ERYT04", "ERYT04", JdeDataType.String, 2),
        new JdeField("ERYT05", "ERYT05", JdeDataType.String, 2),
        new JdeField("ERYT06", "ERYT06", JdeDataType.String, 2),
        new JdeField("ERYT07", "ERYT07", JdeDataType.String, 2),
        new JdeField("ERYT08", "ERYT08", JdeDataType.String, 2),
        new JdeField("ERYFUAMT1", "ERYFUAMT1", JdeDataType.Numeric),
        new JdeField("ERYFUQTY2", "ERYFUQTY2", JdeDataType.Numeric),
        new JdeField("ERYFUQTY3", "ERYFUQTY3", JdeDataType.Numeric),
        new JdeField("ERYFUQTY4", "ERYFUQTY4", JdeDataType.Numeric),
        new JdeField("ERUSER", "ERUSER", JdeDataType.String, 20),
        new JdeField("ERJOBN", "ERJOBN", JdeDataType.String, 20),
        new JdeField("ERPID", "ERPID", JdeDataType.String, 20),
        new JdeField("ERUPMJ", "ERUPMJ", JdeDataType.Numeric),
        new JdeField("ERUPMT", "ERUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I395T_0", "Primary Key on ERSTKT, ERITM, ERKIT, ERITMR, ERSTRX", new[] { "ERSTKT", "ERITM", "ERKIT", "ERITMR", "ERSTRX" }, isUnique: true, isPrimaryKey: true)
    };
}
