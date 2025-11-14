using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B106 - .
/// </summary>
public class F76B106 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SEAN8.
        /// </summary>
        public const string SEAN8 = "SEAN8";

        /// <summary>
        /// SEB76SVTC.
        /// </summary>
        public const string SEB76SVTC = "SEB76SVTC";

        /// <summary>
        /// SEB76CTYC.
        /// </summary>
        public const string SEB76CTYC = "SEB76CTYC";

        /// <summary>
        /// SEB76EPIW.
        /// </summary>
        public const string SEB76EPIW = "SEB76EPIW";

        /// <summary>
        /// SEUSER.
        /// </summary>
        public const string SEUSER = "SEUSER";

        /// <summary>
        /// SEJOBN.
        /// </summary>
        public const string SEJOBN = "SEJOBN";

        /// <summary>
        /// SEPID.
        /// </summary>
        public const string SEPID = "SEPID";

        /// <summary>
        /// SEUPMJ.
        /// </summary>
        public const string SEUPMJ = "SEUPMJ";

        /// <summary>
        /// SEUPMT.
        /// </summary>
        public const string SEUPMT = "SEUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B106";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SEAN8", "SEAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("SEB76SVTC", "SEB76SVTC", JdeDataType.String, 20, true, true),
        new JdeField("SEB76CTYC", "SEB76CTYC", JdeDataType.String, 20, true, true),
        new JdeField("SEB76EPIW", "SEB76EPIW", JdeDataType.Numeric),
        new JdeField("SEUSER", "SEUSER", JdeDataType.String, 20),
        new JdeField("SEJOBN", "SEJOBN", JdeDataType.String, 20),
        new JdeField("SEPID", "SEPID", JdeDataType.String, 20),
        new JdeField("SEUPMJ", "SEUPMJ", JdeDataType.Numeric),
        new JdeField("SEUPMT", "SEUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B106_0", "Primary Key on SEAN8, SEB76SVTC, SEB76CTYC", new[] { "SEAN8", "SEB76SVTC", "SEB76CTYC" }, isUnique: true, isPrimaryKey: true)
    };
}
