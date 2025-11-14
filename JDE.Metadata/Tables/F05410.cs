using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F05410 - .
/// </summary>
public class F05410 : JdeTable
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
        /// ESMUMJ.
        /// </summary>
        public const string ESMUMJ = "ESMUMJ";

        /// <summary>
        /// ESMUMT.
        /// </summary>
        public const string ESMUMT = "ESMUMT";

        /// <summary>
        /// ESUPID.
        /// </summary>
        public const string ESUPID = "ESUPID";

        /// <summary>
        /// ESRT.
        /// </summary>
        public const string ESRT = "ESRT";

        /// <summary>
        /// ESSY.
        /// </summary>
        public const string ESSY = "ESSY";

        /// <summary>
        /// ESKY.
        /// </summary>
        public const string ESKY = "ESKY";

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
    public override string TableName => "F05410";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ESAN8", "ESAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("ESESIGN", "ESESIGN", JdeDataType.String, 32),
        new JdeField("ESMUMJ", "ESMUMJ", JdeDataType.Numeric),
        new JdeField("ESMUMT", "ESMUMT", JdeDataType.Numeric),
        new JdeField("ESUPID", "ESUPID", JdeDataType.String, 20),
        new JdeField("ESRT", "ESRT", JdeDataType.String, 4),
        new JdeField("ESSY", "ESSY", JdeDataType.String, 8),
        new JdeField("ESKY", "ESKY", JdeDataType.String, 20),
        new JdeField("ESUSER", "ESUSER", JdeDataType.String, 20),
        new JdeField("ESPID", "ESPID", JdeDataType.String, 20),
        new JdeField("ESJOBN", "ESJOBN", JdeDataType.String, 20),
        new JdeField("ESUPMJ", "ESUPMJ", JdeDataType.Numeric),
        new JdeField("ESUPMT", "ESUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F05410_0", "Primary Key on ESAN8", new[] { "ESAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
