using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F069140 - .
/// </summary>
public class F069140 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YMAN8.
        /// </summary>
        public const string YMAN8 = "YMAN8";

        /// <summary>
        /// YMPDBA.
        /// </summary>
        public const string YMPDBA = "YMPDBA";

        /// <summary>
        /// YMPSDT.
        /// </summary>
        public const string YMPSDT = "YMPSDT";

        /// <summary>
        /// YMPRTR.
        /// </summary>
        public const string YMPRTR = "YMPRTR";

        /// <summary>
        /// YMGPPL.
        /// </summary>
        public const string YMGPPL = "YMGPPL";

        /// <summary>
        /// YMGMDL.
        /// </summary>
        public const string YMGMDL = "YMGMDL";

        /// <summary>
        /// YMGQDL.
        /// </summary>
        public const string YMGQDL = "YMGQDL";

        /// <summary>
        /// YMGADL.
        /// </summary>
        public const string YMGADL = "YMGADL";

        /// <summary>
        /// YMGSAL.
        /// </summary>
        public const string YMGSAL = "YMGSAL";

        /// <summary>
        /// YMGPPX.
        /// </summary>
        public const string YMGPPX = "YMGPPX";

        /// <summary>
        /// YMGHMN.
        /// </summary>
        public const string YMGHMN = "YMGHMN";

        /// <summary>
        /// YMGHMX.
        /// </summary>
        public const string YMGHMX = "YMGHMX";

        /// <summary>
        /// YMUSER.
        /// </summary>
        public const string YMUSER = "YMUSER";

        /// <summary>
        /// YMPID.
        /// </summary>
        public const string YMPID = "YMPID";

        /// <summary>
        /// YMJOBN.
        /// </summary>
        public const string YMJOBN = "YMJOBN";

        /// <summary>
        /// YMUPMJ.
        /// </summary>
        public const string YMUPMJ = "YMUPMJ";

        /// <summary>
        /// YMUPMT.
        /// </summary>
        public const string YMUPMT = "YMUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F069140";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YMAN8", "YMAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("YMPDBA", "YMPDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("YMPSDT", "YMPSDT", JdeDataType.Numeric, null, true, true),
        new JdeField("YMPRTR", "YMPRTR", JdeDataType.Numeric, null, true, true),
        new JdeField("YMGPPL", "YMGPPL", JdeDataType.Numeric),
        new JdeField("YMGMDL", "YMGMDL", JdeDataType.Numeric),
        new JdeField("YMGQDL", "YMGQDL", JdeDataType.Numeric),
        new JdeField("YMGADL", "YMGADL", JdeDataType.Numeric),
        new JdeField("YMGSAL", "YMGSAL", JdeDataType.Numeric),
        new JdeField("YMGPPX", "YMGPPX", JdeDataType.Numeric),
        new JdeField("YMGHMN", "YMGHMN", JdeDataType.Numeric),
        new JdeField("YMGHMX", "YMGHMX", JdeDataType.Numeric),
        new JdeField("YMUSER", "YMUSER", JdeDataType.String, 20),
        new JdeField("YMPID", "YMPID", JdeDataType.String, 20),
        new JdeField("YMJOBN", "YMJOBN", JdeDataType.String, 20),
        new JdeField("YMUPMJ", "YMUPMJ", JdeDataType.Numeric),
        new JdeField("YMUPMT", "YMUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F069140_0", "Primary Key on YMAN8, YMPDBA, YMPSDT, YMPRTR", new[] { "YMAN8", "YMPDBA", "YMPSDT", "YMPRTR" }, isUnique: true, isPrimaryKey: true)
    };
}
