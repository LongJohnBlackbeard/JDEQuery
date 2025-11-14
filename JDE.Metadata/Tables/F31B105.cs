using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B105 - .
/// </summary>
public class F31B105 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PHNCPATHID.
        /// </summary>
        public const string PHNCPATHID = "PHNCPATHID";

        /// <summary>
        /// PHNCPATHNM.
        /// </summary>
        public const string PHNCPATHNM = "PHNCPATHNM";

        /// <summary>
        /// PHNCPATHDS.
        /// </summary>
        public const string PHNCPATHDS = "PHNCPATHDS";

        /// <summary>
        /// PHWCRTR.
        /// </summary>
        public const string PHWCRTR = "PHWCRTR";

        /// <summary>
        /// PHNCPCC1.
        /// </summary>
        public const string PHNCPCC1 = "PHNCPCC1";

        /// <summary>
        /// PHNCPCC2.
        /// </summary>
        public const string PHNCPCC2 = "PHNCPCC2";

        /// <summary>
        /// PHNCPCC3.
        /// </summary>
        public const string PHNCPCC3 = "PHNCPCC3";

        /// <summary>
        /// PHURAB.
        /// </summary>
        public const string PHURAB = "PHURAB";

        /// <summary>
        /// PHURAT.
        /// </summary>
        public const string PHURAT = "PHURAT";

        /// <summary>
        /// PHURCD.
        /// </summary>
        public const string PHURCD = "PHURCD";

        /// <summary>
        /// PHURDT.
        /// </summary>
        public const string PHURDT = "PHURDT";

        /// <summary>
        /// PHURRF.
        /// </summary>
        public const string PHURRF = "PHURRF";

        /// <summary>
        /// PHWAB.
        /// </summary>
        public const string PHWAB = "PHWAB";

        /// <summary>
        /// PHWNUM.
        /// </summary>
        public const string PHWNUM = "PHWNUM";

        /// <summary>
        /// PHWCD.
        /// </summary>
        public const string PHWCD = "PHWCD";

        /// <summary>
        /// PHWMDT.
        /// </summary>
        public const string PHWMDT = "PHWMDT";

        /// <summary>
        /// PHWRF.
        /// </summary>
        public const string PHWRF = "PHWRF";

        /// <summary>
        /// PHUSER.
        /// </summary>
        public const string PHUSER = "PHUSER";

        /// <summary>
        /// PHUPMJ.
        /// </summary>
        public const string PHUPMJ = "PHUPMJ";

        /// <summary>
        /// PHUPMT.
        /// </summary>
        public const string PHUPMT = "PHUPMT";

        /// <summary>
        /// PHJOBN.
        /// </summary>
        public const string PHJOBN = "PHJOBN";

        /// <summary>
        /// PHMKEY.
        /// </summary>
        public const string PHMKEY = "PHMKEY";

        /// <summary>
        /// PHPID.
        /// </summary>
        public const string PHPID = "PHPID";
    }

    /// <inheritdoc />
    public override string TableName => "F31B105";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PHNCPATHID", "PHNCPATHID", JdeDataType.Numeric, null, true, true),
        new JdeField("PHNCPATHNM", "PHNCPATHNM", JdeDataType.String, 60),
        new JdeField("PHNCPATHDS", "PHNCPATHDS", JdeDataType.String, 60),
        new JdeField("PHWCRTR", "PHWCRTR", JdeDataType.Numeric),
        new JdeField("PHNCPCC1", "PHNCPCC1", JdeDataType.String, 20),
        new JdeField("PHNCPCC2", "PHNCPCC2", JdeDataType.String, 20),
        new JdeField("PHNCPCC3", "PHNCPCC3", JdeDataType.String, 20),
        new JdeField("PHURAB", "PHURAB", JdeDataType.Numeric),
        new JdeField("PHURAT", "PHURAT", JdeDataType.Numeric),
        new JdeField("PHURCD", "PHURCD", JdeDataType.String, 4),
        new JdeField("PHURDT", "PHURDT", JdeDataType.Numeric),
        new JdeField("PHURRF", "PHURRF", JdeDataType.String, 30),
        new JdeField("PHWAB", "PHWAB", JdeDataType.Numeric),
        new JdeField("PHWNUM", "PHWNUM", JdeDataType.Numeric),
        new JdeField("PHWCD", "PHWCD", JdeDataType.String, 6),
        new JdeField("PHWMDT", "PHWMDT", JdeDataType.Numeric),
        new JdeField("PHWRF", "PHWRF", JdeDataType.String, 60),
        new JdeField("PHUSER", "PHUSER", JdeDataType.String, 20),
        new JdeField("PHUPMJ", "PHUPMJ", JdeDataType.Numeric),
        new JdeField("PHUPMT", "PHUPMT", JdeDataType.Numeric),
        new JdeField("PHJOBN", "PHJOBN", JdeDataType.String, 20),
        new JdeField("PHMKEY", "PHMKEY", JdeDataType.String, 30),
        new JdeField("PHPID", "PHPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B105_0", "Primary Key on PHNCPATHID", new[] { "PHNCPATHID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B105_2", "Unique Index on PHNCPATHNM", new[] { "PHNCPATHNM" }, isUnique: true)
    };
}
