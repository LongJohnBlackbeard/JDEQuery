using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F150120D - .
/// </summary>
public class F150120D : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NWTEXR.
        /// </summary>
        public const string NWTEXR = "NWTEXR";

        /// <summary>
        /// NWLNGP.
        /// </summary>
        public const string NWLNGP = "NWLNGP";

        /// <summary>
        /// NWDL01.
        /// </summary>
        public const string NWDL01 = "NWDL01";

        /// <summary>
        /// NWUSER.
        /// </summary>
        public const string NWUSER = "NWUSER";

        /// <summary>
        /// NWPID.
        /// </summary>
        public const string NWPID = "NWPID";

        /// <summary>
        /// NWUPMJ.
        /// </summary>
        public const string NWUPMJ = "NWUPMJ";

        /// <summary>
        /// NWUPMT.
        /// </summary>
        public const string NWUPMT = "NWUPMT";

        /// <summary>
        /// NWJOBN.
        /// </summary>
        public const string NWJOBN = "NWJOBN";

        /// <summary>
        /// NWTORG.
        /// </summary>
        public const string NWTORG = "NWTORG";

        /// <summary>
        /// NWENTJ.
        /// </summary>
        public const string NWENTJ = "NWENTJ";
    }

    /// <inheritdoc />
    public override string TableName => "F150120D";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NWTEXR", "NWTEXR", JdeDataType.String, 20, true, true),
        new JdeField("NWLNGP", "NWLNGP", JdeDataType.String, 4, true, true),
        new JdeField("NWDL01", "NWDL01", JdeDataType.String, 60),
        new JdeField("NWUSER", "NWUSER", JdeDataType.String, 20),
        new JdeField("NWPID", "NWPID", JdeDataType.String, 20),
        new JdeField("NWUPMJ", "NWUPMJ", JdeDataType.Numeric),
        new JdeField("NWUPMT", "NWUPMT", JdeDataType.Numeric),
        new JdeField("NWJOBN", "NWJOBN", JdeDataType.String, 20),
        new JdeField("NWTORG", "NWTORG", JdeDataType.String, 20),
        new JdeField("NWENTJ", "NWENTJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F150120D_0", "Primary Key on NWTEXR, NWLNGP", new[] { "NWTEXR", "NWLNGP" }, isUnique: true, isPrimaryKey: true)
    };
}
