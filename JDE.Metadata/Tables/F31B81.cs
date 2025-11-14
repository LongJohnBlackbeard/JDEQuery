using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B81 - .
/// </summary>
public class F31B81 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VTWCFGID.
        /// </summary>
        public const string VTWCFGID = "VTWCFGID";

        /// <summary>
        /// VTLNID.
        /// </summary>
        public const string VTLNID = "VTLNID";

        /// <summary>
        /// VTWSVT.
        /// </summary>
        public const string VTWSVT = "VTWSVT";

        /// <summary>
        /// VTWLVAL.
        /// </summary>
        public const string VTWLVAL = "VTWLVAL";

        /// <summary>
        /// VTWCFTF.
        /// </summary>
        public const string VTWCFTF = "VTWCFTF";

        /// <summary>
        /// VTURCD.
        /// </summary>
        public const string VTURCD = "VTURCD";

        /// <summary>
        /// VTURDT.
        /// </summary>
        public const string VTURDT = "VTURDT";

        /// <summary>
        /// VTURAT.
        /// </summary>
        public const string VTURAT = "VTURAT";

        /// <summary>
        /// VTURAB.
        /// </summary>
        public const string VTURAB = "VTURAB";

        /// <summary>
        /// VTURRF.
        /// </summary>
        public const string VTURRF = "VTURRF";

        /// <summary>
        /// VTUSER.
        /// </summary>
        public const string VTUSER = "VTUSER";

        /// <summary>
        /// VTPID.
        /// </summary>
        public const string VTPID = "VTPID";

        /// <summary>
        /// VTJOBN.
        /// </summary>
        public const string VTJOBN = "VTJOBN";

        /// <summary>
        /// VTUPMJ.
        /// </summary>
        public const string VTUPMJ = "VTUPMJ";

        /// <summary>
        /// VTTDAY.
        /// </summary>
        public const string VTTDAY = "VTTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F31B81";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VTWCFGID", "VTWCFGID", JdeDataType.Numeric, null, true, true),
        new JdeField("VTLNID", "VTLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("VTWSVT", "VTWSVT", JdeDataType.String, 8),
        new JdeField("VTWLVAL", "VTWLVAL", JdeDataType.String, 2),
        new JdeField("VTWCFTF", "VTWCFTF", JdeDataType.String, 2),
        new JdeField("VTURCD", "VTURCD", JdeDataType.String, 4),
        new JdeField("VTURDT", "VTURDT", JdeDataType.Numeric),
        new JdeField("VTURAT", "VTURAT", JdeDataType.Numeric),
        new JdeField("VTURAB", "VTURAB", JdeDataType.Numeric),
        new JdeField("VTURRF", "VTURRF", JdeDataType.String, 30),
        new JdeField("VTUSER", "VTUSER", JdeDataType.String, 20),
        new JdeField("VTPID", "VTPID", JdeDataType.String, 20),
        new JdeField("VTJOBN", "VTJOBN", JdeDataType.String, 20),
        new JdeField("VTUPMJ", "VTUPMJ", JdeDataType.Numeric),
        new JdeField("VTTDAY", "VTTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B81_0", "Primary Key on VTWCFGID, VTLNID", new[] { "VTWCFGID", "VTLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B81_2", "Index on VTWCFGID, VTWSVT", new[] { "VTWCFGID", "VTWSVT" })
    };
}
