using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76E4010 - .
/// </summary>
public class F76E4010 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CEN002.
        /// </summary>
        public const string CEN002 = "CEN002";

        /// <summary>
        /// CECO.
        /// </summary>
        public const string CECO = "CECO";

        /// <summary>
        /// CEICU.
        /// </summary>
        public const string CEICU = "CEICU";

        /// <summary>
        /// CEICUT.
        /// </summary>
        public const string CEICUT = "CEICUT";

        /// <summary>
        /// CEDCTO.
        /// </summary>
        public const string CEDCTO = "CEDCTO";

        /// <summary>
        /// CEDOCO.
        /// </summary>
        public const string CEDOCO = "CEDOCO";

        /// <summary>
        /// CEAN8.
        /// </summary>
        public const string CEAN8 = "CEAN8";

        /// <summary>
        /// CEVINV.
        /// </summary>
        public const string CEVINV = "CEVINV";

        /// <summary>
        /// CEDGJ.
        /// </summary>
        public const string CEDGJ = "CEDGJ";

        /// <summary>
        /// CEUSER.
        /// </summary>
        public const string CEUSER = "CEUSER";

        /// <summary>
        /// CEJOBN.
        /// </summary>
        public const string CEJOBN = "CEJOBN";

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
    public override string TableName => "F76E4010";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CEN002", "CEN002", JdeDataType.Numeric, null, true, true),
        new JdeField("CECO", "CECO", JdeDataType.String, 10),
        new JdeField("CEICU", "CEICU", JdeDataType.Numeric),
        new JdeField("CEICUT", "CEICUT", JdeDataType.String, 4),
        new JdeField("CEDCTO", "CEDCTO", JdeDataType.String, 4),
        new JdeField("CEDOCO", "CEDOCO", JdeDataType.Numeric),
        new JdeField("CEAN8", "CEAN8", JdeDataType.Numeric),
        new JdeField("CEVINV", "CEVINV", JdeDataType.String, 50),
        new JdeField("CEDGJ", "CEDGJ", JdeDataType.Numeric),
        new JdeField("CEUSER", "CEUSER", JdeDataType.String, 20),
        new JdeField("CEJOBN", "CEJOBN", JdeDataType.String, 20),
        new JdeField("CEUPMJ", "CEUPMJ", JdeDataType.Numeric),
        new JdeField("CEUPMT", "CEUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76E4010_0", "Primary Key on CEN002", new[] { "CEN002" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76E4010_2", "Index on CEICUT, CEICU, CEDCTO, CEDOCO", new[] { "CEICUT", "CEICU", "CEDCTO", "CEDOCO" })
    };
}
