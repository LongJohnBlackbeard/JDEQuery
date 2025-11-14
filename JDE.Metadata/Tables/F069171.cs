using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F069171 - .
/// </summary>
public class F069171 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YPPTT.
        /// </summary>
        public const string YPPTT = "YPPTT";

        /// <summary>
        /// YPPTCP.
        /// </summary>
        public const string YPPTCP = "YPPTCP";

        /// <summary>
        /// YPPTD.
        /// </summary>
        public const string YPPTD = "YPPTD";

        /// <summary>
        /// YPDC.
        /// </summary>
        public const string YPDC = "YPDC";

        /// <summary>
        /// YPDTZR.
        /// </summary>
        public const string YPDTZR = "YPDTZR";

        /// <summary>
        /// YPDTMN.
        /// </summary>
        public const string YPDTMN = "YPDTMN";

        /// <summary>
        /// YPDTME.
        /// </summary>
        public const string YPDTME = "YPDTME";

        /// <summary>
        /// YPDTMX.
        /// </summary>
        public const string YPDTMX = "YPDTMX";

        /// <summary>
        /// YPDMZR.
        /// </summary>
        public const string YPDMZR = "YPDMZR";

        /// <summary>
        /// YPDMMN.
        /// </summary>
        public const string YPDMMN = "YPDMMN";

        /// <summary>
        /// YPDMME.
        /// </summary>
        public const string YPDMME = "YPDMME";

        /// <summary>
        /// YPDMMX.
        /// </summary>
        public const string YPDMMX = "YPDMMX";

        /// <summary>
        /// YPDYZR.
        /// </summary>
        public const string YPDYZR = "YPDYZR";

        /// <summary>
        /// YPDYMN.
        /// </summary>
        public const string YPDYMN = "YPDYMN";

        /// <summary>
        /// YPDYME.
        /// </summary>
        public const string YPDYME = "YPDYME";

        /// <summary>
        /// YPDYMX.
        /// </summary>
        public const string YPDYMX = "YPDYMX";

        /// <summary>
        /// YPDDUE.
        /// </summary>
        public const string YPDDUE = "YPDDUE";

        /// <summary>
        /// YPCKD.
        /// </summary>
        public const string YPCKD = "YPCKD";

        /// <summary>
        /// YPAMRT.
        /// </summary>
        public const string YPAMRT = "YPAMRT";

        /// <summary>
        /// YPRTAM.
        /// </summary>
        public const string YPRTAM = "YPRTAM";

        /// <summary>
        /// YPNDTP.
        /// </summary>
        public const string YPNDTP = "YPNDTP";

        /// <summary>
        /// YPNSP.
        /// </summary>
        public const string YPNSP = "YPNSP";

        /// <summary>
        /// YPDCP.
        /// </summary>
        public const string YPDCP = "YPDCP";

        /// <summary>
        /// YPDCD.
        /// </summary>
        public const string YPDCD = "YPDCD";
    }

    /// <inheritdoc />
    public override string TableName => "F069171";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YPPTT", "YPPTT", JdeDataType.String, 6, true, true),
        new JdeField("YPPTCP", "YPPTCP", JdeDataType.String, 4, true, true),
        new JdeField("YPPTD", "YPPTD", JdeDataType.String, 60),
        new JdeField("YPDC", "YPDC", JdeDataType.String, 80),
        new JdeField("YPDTZR", "YPDTZR", JdeDataType.Numeric),
        new JdeField("YPDTMN", "YPDTMN", JdeDataType.Numeric),
        new JdeField("YPDTME", "YPDTME", JdeDataType.Numeric),
        new JdeField("YPDTMX", "YPDTMX", JdeDataType.Numeric),
        new JdeField("YPDMZR", "YPDMZR", JdeDataType.String, 2),
        new JdeField("YPDMMN", "YPDMMN", JdeDataType.String, 2),
        new JdeField("YPDMME", "YPDMME", JdeDataType.String, 2),
        new JdeField("YPDMMX", "YPDMMX", JdeDataType.String, 2),
        new JdeField("YPDYZR", "YPDYZR", JdeDataType.Numeric),
        new JdeField("YPDYMN", "YPDYMN", JdeDataType.Numeric),
        new JdeField("YPDYME", "YPDYME", JdeDataType.Numeric),
        new JdeField("YPDYMX", "YPDYMX", JdeDataType.Numeric),
        new JdeField("YPDDUE", "YPDDUE", JdeDataType.Numeric),
        new JdeField("YPCKD", "YPCKD", JdeDataType.Numeric),
        new JdeField("YPAMRT", "YPAMRT", JdeDataType.Numeric),
        new JdeField("YPRTAM", "YPRTAM", JdeDataType.Numeric),
        new JdeField("YPNDTP", "YPNDTP", JdeDataType.Numeric),
        new JdeField("YPNSP", "YPNSP", JdeDataType.Numeric),
        new JdeField("YPDCP", "YPDCP", JdeDataType.Numeric),
        new JdeField("YPDCD", "YPDCD", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F069171_0", "Primary Key on YPPTT, YPPTCP", new[] { "YPPTT", "YPPTCP" }, isUnique: true, isPrimaryKey: true)
    };
}
