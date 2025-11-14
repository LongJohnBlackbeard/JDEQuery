using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0013 - .
/// </summary>
public class F0013 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CVCRCD.
        /// </summary>
        public const string CVCRCD = "CVCRCD";

        /// <summary>
        /// CVDL01.
        /// </summary>
        public const string CVDL01 = "CVDL01";

        /// <summary>
        /// CVEC.
        /// </summary>
        public const string CVEC = "CVEC";

        /// <summary>
        /// CVCDEC.
        /// </summary>
        public const string CVCDEC = "CVCDEC";

        /// <summary>
        /// CVCKR.
        /// </summary>
        public const string CVCKR = "CVCKR";

        /// <summary>
        /// CVUSER.
        /// </summary>
        public const string CVUSER = "CVUSER";

        /// <summary>
        /// CVPID.
        /// </summary>
        public const string CVPID = "CVPID";

        /// <summary>
        /// CVUPMJ.
        /// </summary>
        public const string CVUPMJ = "CVUPMJ";

        /// <summary>
        /// CVJOBN.
        /// </summary>
        public const string CVJOBN = "CVJOBN";

        /// <summary>
        /// CVUPMT.
        /// </summary>
        public const string CVUPMT = "CVUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F0013";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CVCRCD", "CVCRCD", JdeDataType.String, 6, true, true),
        new JdeField("CVDL01", "CVDL01", JdeDataType.String, 60),
        new JdeField("CVEC", "CVEC", JdeDataType.String, 2),
        new JdeField("CVCDEC", "CVCDEC", JdeDataType.String, 2),
        new JdeField("CVCKR", "CVCKR", JdeDataType.String, 20),
        new JdeField("CVUSER", "CVUSER", JdeDataType.String, 20),
        new JdeField("CVPID", "CVPID", JdeDataType.String, 20),
        new JdeField("CVUPMJ", "CVUPMJ", JdeDataType.Numeric),
        new JdeField("CVJOBN", "CVJOBN", JdeDataType.String, 20),
        new JdeField("CVUPMT", "CVUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0013_0", "Primary Key on CVCRCD", new[] { "CVCRCD" }, isUnique: true, isPrimaryKey: true)
    };
}
