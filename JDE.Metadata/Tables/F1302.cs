using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1302 - .
/// </summary>
public class F1302 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FKCO.
        /// </summary>
        public const string FKCO = "FKCO";

        /// <summary>
        /// FKMCU.
        /// </summary>
        public const string FKMCU = "FKMCU";

        /// <summary>
        /// FKDT01.
        /// </summary>
        public const string FKDT01 = "FKDT01";

        /// <summary>
        /// FKDT02.
        /// </summary>
        public const string FKDT02 = "FKDT02";

        /// <summary>
        /// FKDT03.
        /// </summary>
        public const string FKDT03 = "FKDT03";

        /// <summary>
        /// FKDT04.
        /// </summary>
        public const string FKDT04 = "FKDT04";

        /// <summary>
        /// FKDT05.
        /// </summary>
        public const string FKDT05 = "FKDT05";

        /// <summary>
        /// FKPO01.
        /// </summary>
        public const string FKPO01 = "FKPO01";

        /// <summary>
        /// FKPO02.
        /// </summary>
        public const string FKPO02 = "FKPO02";

        /// <summary>
        /// FKPO03.
        /// </summary>
        public const string FKPO03 = "FKPO03";

        /// <summary>
        /// FKPO04.
        /// </summary>
        public const string FKPO04 = "FKPO04";

        /// <summary>
        /// FKPO05.
        /// </summary>
        public const string FKPO05 = "FKPO05";

        /// <summary>
        /// FKBILD.
        /// </summary>
        public const string FKBILD = "FKBILD";

        /// <summary>
        /// FKERC.
        /// </summary>
        public const string FKERC = "FKERC";

        /// <summary>
        /// FKBLLM.
        /// </summary>
        public const string FKBLLM = "FKBLLM";

        /// <summary>
        /// FKSBRT.
        /// </summary>
        public const string FKSBRT = "FKSBRT";

        /// <summary>
        /// FKSBPC.
        /// </summary>
        public const string FKSBPC = "FKSBPC";

        /// <summary>
        /// FKBBPR.
        /// </summary>
        public const string FKBBPR = "FKBBPR";

        /// <summary>
        /// FKPRO.
        /// </summary>
        public const string FKPRO = "FKPRO";

        /// <summary>
        /// FKWKEN.
        /// </summary>
        public const string FKWKEN = "FKWKEN";

        /// <summary>
        /// FKRNTT.
        /// </summary>
        public const string FKRNTT = "FKRNTT";

        /// <summary>
        /// FKCORT.
        /// </summary>
        public const string FKCORT = "FKCORT";

        /// <summary>
        /// FKTBEG.
        /// </summary>
        public const string FKTBEG = "FKTBEG";

        /// <summary>
        /// FKTEND.
        /// </summary>
        public const string FKTEND = "FKTEND";

        /// <summary>
        /// FKLCT.
        /// </summary>
        public const string FKLCT = "FKLCT";

        /// <summary>
        /// FKUSER.
        /// </summary>
        public const string FKUSER = "FKUSER";

        /// <summary>
        /// FKPID.
        /// </summary>
        public const string FKPID = "FKPID";

        /// <summary>
        /// FKJOBN.
        /// </summary>
        public const string FKJOBN = "FKJOBN";

        /// <summary>
        /// FKUPMT.
        /// </summary>
        public const string FKUPMT = "FKUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F1302";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FKCO", "FKCO", JdeDataType.String, 10, true, true),
        new JdeField("FKMCU", "FKMCU", JdeDataType.String, 24, true, true),
        new JdeField("FKDT01", "FKDT01", JdeDataType.String, 6),
        new JdeField("FKDT02", "FKDT02", JdeDataType.String, 6),
        new JdeField("FKDT03", "FKDT03", JdeDataType.String, 6),
        new JdeField("FKDT04", "FKDT04", JdeDataType.String, 6),
        new JdeField("FKDT05", "FKDT05", JdeDataType.String, 6),
        new JdeField("FKPO01", "FKPO01", JdeDataType.Numeric),
        new JdeField("FKPO02", "FKPO02", JdeDataType.Numeric),
        new JdeField("FKPO03", "FKPO03", JdeDataType.Numeric),
        new JdeField("FKPO04", "FKPO04", JdeDataType.Numeric),
        new JdeField("FKPO05", "FKPO05", JdeDataType.Numeric),
        new JdeField("FKBILD", "FKBILD", JdeDataType.Numeric),
        new JdeField("FKERC", "FKERC", JdeDataType.String, 4),
        new JdeField("FKBLLM", "FKBLLM", JdeDataType.Numeric),
        new JdeField("FKSBRT", "FKSBRT", JdeDataType.String, 6),
        new JdeField("FKSBPC", "FKSBPC", JdeDataType.Numeric),
        new JdeField("FKBBPR", "FKBBPR", JdeDataType.Numeric),
        new JdeField("FKPRO", "FKPRO", JdeDataType.String, 2),
        new JdeField("FKWKEN", "FKWKEN", JdeDataType.String, 2),
        new JdeField("FKRNTT", "FKRNTT", JdeDataType.Numeric),
        new JdeField("FKCORT", "FKCORT", JdeDataType.String, 6),
        new JdeField("FKTBEG", "FKTBEG", JdeDataType.Numeric),
        new JdeField("FKTEND", "FKTEND", JdeDataType.Numeric),
        new JdeField("FKLCT", "FKLCT", JdeDataType.Numeric),
        new JdeField("FKUSER", "FKUSER", JdeDataType.String, 20),
        new JdeField("FKPID", "FKPID", JdeDataType.String, 20),
        new JdeField("FKJOBN", "FKJOBN", JdeDataType.String, 20),
        new JdeField("FKUPMT", "FKUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1302_0", "Primary Key on FKCO, FKMCU", new[] { "FKCO", "FKMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
