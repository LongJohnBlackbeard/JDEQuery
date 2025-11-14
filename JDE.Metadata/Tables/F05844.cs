using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F05844 - .
/// </summary>
public class F05844 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AHHMCO.
        /// </summary>
        public const string AHHMCO = "AHHMCO";

        /// <summary>
        /// AHHMCU.
        /// </summary>
        public const string AHHMCU = "AHHMCU";

        /// <summary>
        /// AHAPPTY.
        /// </summary>
        public const string AHAPPTY = "AHAPPTY";

        /// <summary>
        /// AHLVELT.
        /// </summary>
        public const string AHLVELT = "AHLVELT";

        /// <summary>
        /// AHLVELF.
        /// </summary>
        public const string AHLVELF = "AHLVELF";

        /// <summary>
        /// AHANHA.
        /// </summary>
        public const string AHANHA = "AHANHA";

        /// <summary>
        /// AHUSER.
        /// </summary>
        public const string AHUSER = "AHUSER";

        /// <summary>
        /// AHPID.
        /// </summary>
        public const string AHPID = "AHPID";

        /// <summary>
        /// AHUPMJ.
        /// </summary>
        public const string AHUPMJ = "AHUPMJ";

        /// <summary>
        /// AHUPMT.
        /// </summary>
        public const string AHUPMT = "AHUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F05844";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AHHMCO", "AHHMCO", JdeDataType.String, 10, true, true),
        new JdeField("AHHMCU", "AHHMCU", JdeDataType.String, 24, true, true),
        new JdeField("AHAPPTY", "AHAPPTY", JdeDataType.String, 8, true, true),
        new JdeField("AHLVELT", "AHLVELT", JdeDataType.Numeric),
        new JdeField("AHLVELF", "AHLVELF", JdeDataType.Numeric),
        new JdeField("AHANHA", "AHANHA", JdeDataType.Numeric),
        new JdeField("AHUSER", "AHUSER", JdeDataType.String, 20),
        new JdeField("AHPID", "AHPID", JdeDataType.String, 20),
        new JdeField("AHUPMJ", "AHUPMJ", JdeDataType.Numeric),
        new JdeField("AHUPMT", "AHUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F05844_0", "Primary Key on AHHMCO, AHAPPTY, AHHMCU", new[] { "AHHMCO", "AHAPPTY", "AHHMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
