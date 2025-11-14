using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74R0401 - .
/// </summary>
public class F74R0401 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ADR74ADNU.
        /// </summary>
        public const string ADR74ADNU = "ADR74ADNU";

        /// <summary>
        /// ADOKCO.
        /// </summary>
        public const string ADOKCO = "ADOKCO";

        /// <summary>
        /// ADOCTO.
        /// </summary>
        public const string ADOCTO = "ADOCTO";

        /// <summary>
        /// ADODOC.
        /// </summary>
        public const string ADODOC = "ADODOC";

        /// <summary>
        /// ADR74ADDT.
        /// </summary>
        public const string ADR74ADDT = "ADR74ADDT";

        /// <summary>
        /// ADURRF.
        /// </summary>
        public const string ADURRF = "ADURRF";

        /// <summary>
        /// ADURDT.
        /// </summary>
        public const string ADURDT = "ADURDT";

        /// <summary>
        /// ADURC1.
        /// </summary>
        public const string ADURC1 = "ADURC1";

        /// <summary>
        /// ADURAT.
        /// </summary>
        public const string ADURAT = "ADURAT";

        /// <summary>
        /// ADURAB.
        /// </summary>
        public const string ADURAB = "ADURAB";

        /// <summary>
        /// ADUSER.
        /// </summary>
        public const string ADUSER = "ADUSER";

        /// <summary>
        /// ADPID.
        /// </summary>
        public const string ADPID = "ADPID";

        /// <summary>
        /// ADJOBN.
        /// </summary>
        public const string ADJOBN = "ADJOBN";

        /// <summary>
        /// ADUPMJ.
        /// </summary>
        public const string ADUPMJ = "ADUPMJ";

        /// <summary>
        /// ADUPMT.
        /// </summary>
        public const string ADUPMT = "ADUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74R0401";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ADR74ADNU", "ADR74ADNU", JdeDataType.String, 50, true, true),
        new JdeField("ADOKCO", "ADOKCO", JdeDataType.String, 10, true, true),
        new JdeField("ADOCTO", "ADOCTO", JdeDataType.String, 4, true, true),
        new JdeField("ADODOC", "ADODOC", JdeDataType.Numeric, null, true, true),
        new JdeField("ADR74ADDT", "ADR74ADDT", JdeDataType.Numeric),
        new JdeField("ADURRF", "ADURRF", JdeDataType.String, 30),
        new JdeField("ADURDT", "ADURDT", JdeDataType.Numeric),
        new JdeField("ADURC1", "ADURC1", JdeDataType.String, 6),
        new JdeField("ADURAT", "ADURAT", JdeDataType.Numeric),
        new JdeField("ADURAB", "ADURAB", JdeDataType.Numeric),
        new JdeField("ADUSER", "ADUSER", JdeDataType.String, 20),
        new JdeField("ADPID", "ADPID", JdeDataType.String, 20),
        new JdeField("ADJOBN", "ADJOBN", JdeDataType.String, 20),
        new JdeField("ADUPMJ", "ADUPMJ", JdeDataType.Numeric),
        new JdeField("ADUPMT", "ADUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74R0401_0", "Primary Key on ADR74ADNU, ADOKCO, ADODOC, ADOCTO", new[] { "ADR74ADNU", "ADOKCO", "ADODOC", "ADOCTO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74R0401_2", "Index on ADR74ADDT, ADOKCO, ADODOC, ADOCTO", new[] { "ADR74ADDT", "ADOKCO", "ADODOC", "ADOCTO" })
    };
}
