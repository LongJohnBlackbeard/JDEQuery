using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U421A - .
/// </summary>
public class F74U421A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AHKCOO.
        /// </summary>
        public const string AHKCOO = "AHKCOO";

        /// <summary>
        /// AHDCTO.
        /// </summary>
        public const string AHDCTO = "AHDCTO";

        /// <summary>
        /// AHDOCO.
        /// </summary>
        public const string AHDOCO = "AHDOCO";

        /// <summary>
        /// AHUKAPNM.
        /// </summary>
        public const string AHUKAPNM = "AHUKAPNM";

        /// <summary>
        /// AHARTG.
        /// </summary>
        public const string AHARTG = "AHARTG";

        /// <summary>
        /// AHUKID.
        /// </summary>
        public const string AHUKID = "AHUKID";

        /// <summary>
        /// AHRPER.
        /// </summary>
        public const string AHRPER = "AHRPER";

        /// <summary>
        /// AH74UAP1.
        /// </summary>
        public const string AH74UAP1 = "AH74UAP1";

        /// <summary>
        /// AHUPMJ.
        /// </summary>
        public const string AHUPMJ = "AHUPMJ";

        /// <summary>
        /// AHUPMT.
        /// </summary>
        public const string AHUPMT = "AHUPMT";

        /// <summary>
        /// AHUSER.
        /// </summary>
        public const string AHUSER = "AHUSER";

        /// <summary>
        /// AHPID.
        /// </summary>
        public const string AHPID = "AHPID";

        /// <summary>
        /// AHJOBN.
        /// </summary>
        public const string AHJOBN = "AHJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74U421A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AHKCOO", "AHKCOO", JdeDataType.String, 10, true, true),
        new JdeField("AHDCTO", "AHDCTO", JdeDataType.String, 4, true, true),
        new JdeField("AHDOCO", "AHDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("AHUKAPNM", "AHUKAPNM", JdeDataType.Numeric, null, true, true),
        new JdeField("AHARTG", "AHARTG", JdeDataType.String, 24, true, true),
        new JdeField("AHUKID", "AHUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("AHRPER", "AHRPER", JdeDataType.Numeric),
        new JdeField("AH74UAP1", "AH74UAP1", JdeDataType.Numeric),
        new JdeField("AHUPMJ", "AHUPMJ", JdeDataType.Numeric),
        new JdeField("AHUPMT", "AHUPMT", JdeDataType.Numeric),
        new JdeField("AHUSER", "AHUSER", JdeDataType.String, 20),
        new JdeField("AHPID", "AHPID", JdeDataType.String, 20),
        new JdeField("AHJOBN", "AHJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U421A_0", "Primary Key on AHKCOO, AHDCTO, AHDOCO, AHUKAPNM, AHARTG, AHUKID", new[] { "AHKCOO", "AHDCTO", "AHDOCO", "AHUKAPNM", "AHARTG", "AHUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74U421A_2", "Index on AHKCOO, AHDCTO, AHDOCO, AHUKAPNM, AHARTG, AHRPER", new[] { "AHKCOO", "AHDCTO", "AHDOCO", "AHUKAPNM", "AHARTG", "AHRPER" })
    };
}
