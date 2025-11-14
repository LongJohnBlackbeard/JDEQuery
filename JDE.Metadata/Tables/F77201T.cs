using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F77201T - .
/// </summary>
public class F77201T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NAYEID.
        /// </summary>
        public const string NAYEID = "NAYEID";

        /// <summary>
        /// NATAXYR.
        /// </summary>
        public const string NATAXYR = "NATAXYR";

        /// <summary>
        /// NAAN8.
        /// </summary>
        public const string NAAN8 = "NAAN8";

        /// <summary>
        /// NAFORMSID.
        /// </summary>
        public const string NAFORMSID = "NAFORMSID";

        /// <summary>
        /// NAFORMD.
        /// </summary>
        public const string NAFORMD = "NAFORMD";

        /// <summary>
        /// NACO.
        /// </summary>
        public const string NACO = "NACO";

        /// <summary>
        /// NATARA.
        /// </summary>
        public const string NATARA = "NATARA";

        /// <summary>
        /// NATAXX.
        /// </summary>
        public const string NATAXX = "NATAXX";

        /// <summary>
        /// NASSN.
        /// </summary>
        public const string NASSN = "NASSN";

        /// <summary>
        /// NAALPH.
        /// </summary>
        public const string NAALPH = "NAALPH";
    }

    /// <inheritdoc />
    public override string TableName => "F77201T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NAYEID", "NAYEID", JdeDataType.String, 20, true, true),
        new JdeField("NATAXYR", "NATAXYR", JdeDataType.Numeric, null, true, true),
        new JdeField("NAAN8", "NAAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("NAFORMSID", "NAFORMSID", JdeDataType.Numeric, null, true, true),
        new JdeField("NAFORMD", "NAFORMD", JdeDataType.String, 80),
        new JdeField("NACO", "NACO", JdeDataType.String, 10, true, true),
        new JdeField("NATARA", "NATARA", JdeDataType.String, 20, true, true),
        new JdeField("NATAXX", "NATAXX", JdeDataType.String, 40, true, true),
        new JdeField("NASSN", "NASSN", JdeDataType.String, 40),
        new JdeField("NAALPH", "NAALPH", JdeDataType.String, 80)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F77201T_0", "Primary Key on NAYEID, NATAXYR, NAAN8, NAFORMSID, NACO, NATARA, NATAXX", new[] { "NAYEID", "NATAXYR", "NAAN8", "NAFORMSID", "NACO", "NATARA", "NATAXX" }, isUnique: true, isPrimaryKey: true)
    };
}
