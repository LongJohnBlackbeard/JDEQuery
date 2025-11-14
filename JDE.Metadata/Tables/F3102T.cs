using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3102T - .
/// </summary>
public class F3102T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IGDOCO.
        /// </summary>
        public const string IGDOCO = "IGDOCO";

        /// <summary>
        /// IGITM.
        /// </summary>
        public const string IGITM = "IGITM";

        /// <summary>
        /// IGCOST.
        /// </summary>
        public const string IGCOST = "IGCOST";

        /// <summary>
        /// IGPART.
        /// </summary>
        public const string IGPART = "IGPART";

        /// <summary>
        /// IGENGV.
        /// </summary>
        public const string IGENGV = "IGENGV";

        /// <summary>
        /// IGPLNV.
        /// </summary>
        public const string IGPLNV = "IGPLNV";

        /// <summary>
        /// IGVACT.
        /// </summary>
        public const string IGVACT = "IGVACT";

        /// <summary>
        /// IGOTHV.
        /// </summary>
        public const string IGOTHV = "IGOTHV";

        /// <summary>
        /// IGNETV.
        /// </summary>
        public const string IGNETV = "IGNETV";

        /// <summary>
        /// IGUSER.
        /// </summary>
        public const string IGUSER = "IGUSER";

        /// <summary>
        /// IGPID.
        /// </summary>
        public const string IGPID = "IGPID";

        /// <summary>
        /// IGUPMJ.
        /// </summary>
        public const string IGUPMJ = "IGUPMJ";

        /// <summary>
        /// IGTDAY.
        /// </summary>
        public const string IGTDAY = "IGTDAY";

        /// <summary>
        /// IGJOBN.
        /// </summary>
        public const string IGJOBN = "IGJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F3102T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IGDOCO", "IGDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("IGITM", "IGITM", JdeDataType.Numeric, null, true, true),
        new JdeField("IGCOST", "IGCOST", JdeDataType.String, 6, true, true),
        new JdeField("IGPART", "IGPART", JdeDataType.String, 2, true, true),
        new JdeField("IGENGV", "IGENGV", JdeDataType.Numeric),
        new JdeField("IGPLNV", "IGPLNV", JdeDataType.Numeric),
        new JdeField("IGVACT", "IGVACT", JdeDataType.Numeric),
        new JdeField("IGOTHV", "IGOTHV", JdeDataType.Numeric),
        new JdeField("IGNETV", "IGNETV", JdeDataType.Numeric),
        new JdeField("IGUSER", "IGUSER", JdeDataType.String, 20),
        new JdeField("IGPID", "IGPID", JdeDataType.String, 20),
        new JdeField("IGUPMJ", "IGUPMJ", JdeDataType.Numeric),
        new JdeField("IGTDAY", "IGTDAY", JdeDataType.Numeric),
        new JdeField("IGJOBN", "IGJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3102T_0", "Primary Key on IGDOCO, IGPART, IGITM, IGCOST", new[] { "IGDOCO", "IGPART", "IGITM", "IGCOST" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F3102T_2", "Index on IGDOCO, IGITM, IGCOST", new[] { "IGDOCO", "IGITM", "IGCOST" })
    };
}
