using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1385 - .
/// </summary>
public class F1385 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ERECAT.
        /// </summary>
        public const string ERECAT = "ERECAT";

        /// <summary>
        /// ERCO.
        /// </summary>
        public const string ERCO = "ERCO";

        /// <summary>
        /// ERLT.
        /// </summary>
        public const string ERLT = "ERLT";

        /// <summary>
        /// ERMCU.
        /// </summary>
        public const string ERMCU = "ERMCU";

        /// <summary>
        /// EROBJ.
        /// </summary>
        public const string EROBJ = "EROBJ";

        /// <summary>
        /// ERSUB.
        /// </summary>
        public const string ERSUB = "ERSUB";

        /// <summary>
        /// ERDCT.
        /// </summary>
        public const string ERDCT = "ERDCT";

        /// <summary>
        /// ERCCFC.
        /// </summary>
        public const string ERCCFC = "ERCCFC";

        /// <summary>
        /// ERUPMT.
        /// </summary>
        public const string ERUPMT = "ERUPMT";

        /// <summary>
        /// ERUSER.
        /// </summary>
        public const string ERUSER = "ERUSER";

        /// <summary>
        /// ERPID.
        /// </summary>
        public const string ERPID = "ERPID";

        /// <summary>
        /// ERMKEY.
        /// </summary>
        public const string ERMKEY = "ERMKEY";

        /// <summary>
        /// ERUPMJ.
        /// </summary>
        public const string ERUPMJ = "ERUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F1385";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ERECAT", "ERECAT", JdeDataType.String, 20, true, true),
        new JdeField("ERCO", "ERCO", JdeDataType.String, 10, true, true),
        new JdeField("ERLT", "ERLT", JdeDataType.String, 4, true, true),
        new JdeField("ERMCU", "ERMCU", JdeDataType.String, 24, true, true),
        new JdeField("EROBJ", "EROBJ", JdeDataType.String, 12, true, true),
        new JdeField("ERSUB", "ERSUB", JdeDataType.String, 16, true, true),
        new JdeField("ERDCT", "ERDCT", JdeDataType.String, 4, true, true),
        new JdeField("ERCCFC", "ERCCFC", JdeDataType.String, 4),
        new JdeField("ERUPMT", "ERUPMT", JdeDataType.Numeric),
        new JdeField("ERUSER", "ERUSER", JdeDataType.String, 20),
        new JdeField("ERPID", "ERPID", JdeDataType.String, 20),
        new JdeField("ERMKEY", "ERMKEY", JdeDataType.String, 30),
        new JdeField("ERUPMJ", "ERUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1385_0", "Primary Key on ERECAT, ERCO, ERLT, ERMCU, EROBJ, ERSUB, ERDCT", new[] { "ERECAT", "ERCO", "ERLT", "ERMCU", "EROBJ", "ERSUB", "ERDCT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F1385_2", "Index on ERECAT, ERCO, ERLT, EROBJ, ERSUB, ERMCU", new[] { "ERECAT", "ERCO", "ERLT", "EROBJ", "ERSUB", "ERMCU" })
    };
}
