using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F48091C - .
/// </summary>
public class F48091C : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CECO.
        /// </summary>
        public const string CECO = "CECO";

        /// <summary>
        /// CEPID.
        /// </summary>
        public const string CEPID = "CEPID";

        /// <summary>
        /// CEMKEY.
        /// </summary>
        public const string CEMKEY = "CEMKEY";

        /// <summary>
        /// CEUSER.
        /// </summary>
        public const string CEUSER = "CEUSER";

        /// <summary>
        /// CEUPMJ.
        /// </summary>
        public const string CEUPMJ = "CEUPMJ";

        /// <summary>
        /// CEUPMT.
        /// </summary>
        public const string CEUPMT = "CEUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F48091C";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CECO", "CECO", JdeDataType.String, 10, true, true),
        new JdeField("CEPID", "CEPID", JdeDataType.String, 20),
        new JdeField("CEMKEY", "CEMKEY", JdeDataType.String, 30),
        new JdeField("CEUSER", "CEUSER", JdeDataType.String, 20),
        new JdeField("CEUPMJ", "CEUPMJ", JdeDataType.Numeric),
        new JdeField("CEUPMT", "CEUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F48091C_0", "Primary Key on CECO", new[] { "CECO" }, isUnique: true, isPrimaryKey: true)
    };
}
