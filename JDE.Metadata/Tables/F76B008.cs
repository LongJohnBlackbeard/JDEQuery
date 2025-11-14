using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B008 - .
/// </summary>
public class F76B008 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LEB76TNF.
        /// </summary>
        public const string LEB76TNF = "LEB76TNF";

        /// <summary>
        /// LEB76LSERL.
        /// </summary>
        public const string LEB76LSERL = "LEB76LSERL";

        /// <summary>
        /// LEB76LNNF.
        /// </summary>
        public const string LEB76LNNF = "LEB76LNNF";

        /// <summary>
        /// LEUSER.
        /// </summary>
        public const string LEUSER = "LEUSER";

        /// <summary>
        /// LEPID.
        /// </summary>
        public const string LEPID = "LEPID";

        /// <summary>
        /// LEJOBN.
        /// </summary>
        public const string LEJOBN = "LEJOBN";

        /// <summary>
        /// LEUPMJ.
        /// </summary>
        public const string LEUPMJ = "LEUPMJ";

        /// <summary>
        /// LEUPMT.
        /// </summary>
        public const string LEUPMT = "LEUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B008";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LEB76TNF", "LEB76TNF", JdeDataType.String, 20, true, true),
        new JdeField("LEB76LSERL", "LEB76LSERL", JdeDataType.Numeric),
        new JdeField("LEB76LNNF", "LEB76LNNF", JdeDataType.Numeric),
        new JdeField("LEUSER", "LEUSER", JdeDataType.String, 20),
        new JdeField("LEPID", "LEPID", JdeDataType.String, 20),
        new JdeField("LEJOBN", "LEJOBN", JdeDataType.String, 20),
        new JdeField("LEUPMJ", "LEUPMJ", JdeDataType.Numeric),
        new JdeField("LEUPMT", "LEUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B008_0", "Primary Key on LEB76TNF", new[] { "LEB76TNF" }, isUnique: true, isPrimaryKey: true)
    };
}
