using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F085528 - .
/// </summary>
public class F085528 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ESAN8.
        /// </summary>
        public const string ESAN8 = "ESAN8";

        /// <summary>
        /// ESESIGN.
        /// </summary>
        public const string ESESIGN = "ESESIGN";

        /// <summary>
        /// ESOBNM.
        /// </summary>
        public const string ESOBNM = "ESOBNM";

        /// <summary>
        /// ESEECD.
        /// </summary>
        public const string ESEECD = "ESEECD";

        /// <summary>
        /// ESUSER.
        /// </summary>
        public const string ESUSER = "ESUSER";

        /// <summary>
        /// ESPID.
        /// </summary>
        public const string ESPID = "ESPID";

        /// <summary>
        /// ESJOBN.
        /// </summary>
        public const string ESJOBN = "ESJOBN";

        /// <summary>
        /// ESUPMJ.
        /// </summary>
        public const string ESUPMJ = "ESUPMJ";

        /// <summary>
        /// ESUPMT.
        /// </summary>
        public const string ESUPMT = "ESUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F085528";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ESAN8", "ESAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("ESESIGN", "ESESIGN", JdeDataType.String, 32, true, true),
        new JdeField("ESOBNM", "ESOBNM", JdeDataType.String, 20, true, true),
        new JdeField("ESEECD", "ESEECD", JdeDataType.String, 6),
        new JdeField("ESUSER", "ESUSER", JdeDataType.String, 20),
        new JdeField("ESPID", "ESPID", JdeDataType.String, 20),
        new JdeField("ESJOBN", "ESJOBN", JdeDataType.String, 20),
        new JdeField("ESUPMJ", "ESUPMJ", JdeDataType.Numeric),
        new JdeField("ESUPMT", "ESUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F085528_0", "Primary Key on ESAN8, ESESIGN, ESOBNM", new[] { "ESAN8", "ESESIGN", "ESOBNM" }, isUnique: true, isPrimaryKey: true)
    };
}
