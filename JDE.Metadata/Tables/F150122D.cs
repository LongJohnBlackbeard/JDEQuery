using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F150122D - .
/// </summary>
public class F150122D : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NYSFDN.
        /// </summary>
        public const string NYSFDN = "NYSFDN";

        /// <summary>
        /// NYLNGP.
        /// </summary>
        public const string NYLNGP = "NYLNGP";

        /// <summary>
        /// NYDL01.
        /// </summary>
        public const string NYDL01 = "NYDL01";

        /// <summary>
        /// NYUSER.
        /// </summary>
        public const string NYUSER = "NYUSER";

        /// <summary>
        /// NYPID.
        /// </summary>
        public const string NYPID = "NYPID";

        /// <summary>
        /// NYUPMJ.
        /// </summary>
        public const string NYUPMJ = "NYUPMJ";

        /// <summary>
        /// NYUPMT.
        /// </summary>
        public const string NYUPMT = "NYUPMT";

        /// <summary>
        /// NYJOBN.
        /// </summary>
        public const string NYJOBN = "NYJOBN";

        /// <summary>
        /// NYTORG.
        /// </summary>
        public const string NYTORG = "NYTORG";

        /// <summary>
        /// NYENTJ.
        /// </summary>
        public const string NYENTJ = "NYENTJ";
    }

    /// <inheritdoc />
    public override string TableName => "F150122D";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NYSFDN", "NYSFDN", JdeDataType.String, 20, true, true),
        new JdeField("NYLNGP", "NYLNGP", JdeDataType.String, 4, true, true),
        new JdeField("NYDL01", "NYDL01", JdeDataType.String, 60),
        new JdeField("NYUSER", "NYUSER", JdeDataType.String, 20),
        new JdeField("NYPID", "NYPID", JdeDataType.String, 20),
        new JdeField("NYUPMJ", "NYUPMJ", JdeDataType.Numeric),
        new JdeField("NYUPMT", "NYUPMT", JdeDataType.Numeric),
        new JdeField("NYJOBN", "NYJOBN", JdeDataType.String, 20),
        new JdeField("NYTORG", "NYTORG", JdeDataType.String, 20),
        new JdeField("NYENTJ", "NYENTJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F150122D_0", "Primary Key on NYSFDN, NYLNGP", new[] { "NYSFDN", "NYLNGP" }, isUnique: true, isPrimaryKey: true)
    };
}
