using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F79A10 - .
/// </summary>
public class F79A10 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ER79AGERID.
        /// </summary>
        public const string ER79AGERID = "ER79AGERID";

        /// <summary>
        /// ER79AGESID.
        /// </summary>
        public const string ER79AGESID = "ER79AGESID";

        /// <summary>
        /// ER79AEMSC.
        /// </summary>
        public const string ER79AEMSC = "ER79AEMSC";

        /// <summary>
        /// ERMCU.
        /// </summary>
        public const string ERMCU = "ERMCU";

        /// <summary>
        /// ERAN8.
        /// </summary>
        public const string ERAN8 = "ERAN8";

        /// <summary>
        /// ERNUMB.
        /// </summary>
        public const string ERNUMB = "ERNUMB";

        /// <summary>
        /// ER79AGETY.
        /// </summary>
        public const string ER79AGETY = "ER79AGETY";

        /// <summary>
        /// ERBEFD.
        /// </summary>
        public const string ERBEFD = "ERBEFD";

        /// <summary>
        /// EREEFD.
        /// </summary>
        public const string EREEFD = "EREEFD";

        /// <summary>
        /// ER79AGUM.
        /// </summary>
        public const string ER79AGUM = "ER79AGUM";

        /// <summary>
        /// ER79AEUQTY.
        /// </summary>
        public const string ER79AEUQTY = "ER79AEUQTY";

        /// <summary>
        /// ER79AGHGER.
        /// </summary>
        public const string ER79AGHGER = "ER79AGHGER";

        /// <summary>
        /// ER79AGCUM.
        /// </summary>
        public const string ER79AGCUM = "ER79AGCUM";

        /// <summary>
        /// ER79AGCUQ.
        /// </summary>
        public const string ER79AGCUQ = "ER79AGCUQ";

        /// <summary>
        /// ER79AGCOER.
        /// </summary>
        public const string ER79AGCOER = "ER79AGCOER";

        /// <summary>
        /// ER79AGCM.
        /// </summary>
        public const string ER79AGCM = "ER79AGCM";

        /// <summary>
        /// ER79AGCS.
        /// </summary>
        public const string ER79AGCS = "ER79AGCS";

        /// <summary>
        /// ERURCD.
        /// </summary>
        public const string ERURCD = "ERURCD";

        /// <summary>
        /// ERURDT.
        /// </summary>
        public const string ERURDT = "ERURDT";

        /// <summary>
        /// ERURAT.
        /// </summary>
        public const string ERURAT = "ERURAT";

        /// <summary>
        /// ERURAB.
        /// </summary>
        public const string ERURAB = "ERURAB";

        /// <summary>
        /// ERURRF.
        /// </summary>
        public const string ERURRF = "ERURRF";

        /// <summary>
        /// ERUSER.
        /// </summary>
        public const string ERUSER = "ERUSER";

        /// <summary>
        /// ERPID.
        /// </summary>
        public const string ERPID = "ERPID";

        /// <summary>
        /// ERJOBN.
        /// </summary>
        public const string ERJOBN = "ERJOBN";

        /// <summary>
        /// ERUPMJ.
        /// </summary>
        public const string ERUPMJ = "ERUPMJ";

        /// <summary>
        /// ERUPMT.
        /// </summary>
        public const string ERUPMT = "ERUPMT";

        /// <summary>
        /// ER79AGOID.
        /// </summary>
        public const string ER79AGOID = "ER79AGOID";

        /// <summary>
        /// ERCOUN.
        /// </summary>
        public const string ERCOUN = "ERCOUN";

        /// <summary>
        /// ERADDS.
        /// </summary>
        public const string ERADDS = "ERADDS";

        /// <summary>
        /// ERCTR.
        /// </summary>
        public const string ERCTR = "ERCTR";
    }

    /// <inheritdoc />
    public override string TableName => "F79A10";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ER79AGERID", "ER79AGERID", JdeDataType.Numeric, null, true, true),
        new JdeField("ER79AGESID", "ER79AGESID", JdeDataType.Numeric),
        new JdeField("ER79AEMSC", "ER79AEMSC", JdeDataType.String, 20),
        new JdeField("ERMCU", "ERMCU", JdeDataType.String, 24),
        new JdeField("ERAN8", "ERAN8", JdeDataType.Numeric),
        new JdeField("ERNUMB", "ERNUMB", JdeDataType.Numeric),
        new JdeField("ER79AGETY", "ER79AGETY", JdeDataType.String, 20),
        new JdeField("ERBEFD", "ERBEFD", JdeDataType.Numeric),
        new JdeField("EREEFD", "EREEFD", JdeDataType.Numeric),
        new JdeField("ER79AGUM", "ER79AGUM", JdeDataType.String, 30),
        new JdeField("ER79AEUQTY", "ER79AEUQTY", JdeDataType.Numeric),
        new JdeField("ER79AGHGER", "ER79AGHGER", JdeDataType.Numeric),
        new JdeField("ER79AGCUM", "ER79AGCUM", JdeDataType.String, 4),
        new JdeField("ER79AGCUQ", "ER79AGCUQ", JdeDataType.Numeric),
        new JdeField("ER79AGCOER", "ER79AGCOER", JdeDataType.Numeric),
        new JdeField("ER79AGCM", "ER79AGCM", JdeDataType.String, 4),
        new JdeField("ER79AGCS", "ER79AGCS", JdeDataType.String, 240),
        new JdeField("ERURCD", "ERURCD", JdeDataType.String, 4),
        new JdeField("ERURDT", "ERURDT", JdeDataType.Numeric),
        new JdeField("ERURAT", "ERURAT", JdeDataType.Numeric),
        new JdeField("ERURAB", "ERURAB", JdeDataType.Numeric),
        new JdeField("ERURRF", "ERURRF", JdeDataType.String, 30),
        new JdeField("ERUSER", "ERUSER", JdeDataType.String, 20),
        new JdeField("ERPID", "ERPID", JdeDataType.String, 20),
        new JdeField("ERJOBN", "ERJOBN", JdeDataType.String, 20),
        new JdeField("ERUPMJ", "ERUPMJ", JdeDataType.Numeric),
        new JdeField("ERUPMT", "ERUPMT", JdeDataType.Numeric),
        new JdeField("ER79AGOID", "ER79AGOID", JdeDataType.Numeric),
        new JdeField("ERCOUN", "ERCOUN", JdeDataType.String, 50),
        new JdeField("ERADDS", "ERADDS", JdeDataType.String, 6),
        new JdeField("ERCTR", "ERCTR", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F79A10_0", "Primary Key on ER79AGERID", new[] { "ER79AGERID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F79A10_2", "Index on ER79AGESID, ER79AEMSC, ER79AGETY, ER79AGOID, ERMCU, ERAN8, ERNUMB, ERCOUN, ERADDS, ERCTR, ERBEFD", new[] { "ER79AGESID", "ER79AEMSC", "ER79AGETY", "ER79AGOID", "ERMCU", "ERAN8", "ERNUMB", "ERCOUN", "ERADDS", "ERCTR", "ERBEFD" }),
        new JdeIndex("F79A10_3", "Index on ERMCU, ERBEFD", new[] { "ERMCU", "ERBEFD" }),
        new JdeIndex("F79A10_4", "Index on ER79AGOID, ERBEFD", new[] { "ER79AGOID", "ERBEFD" })
    };
}
