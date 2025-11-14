using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B400A - .
/// </summary>
public class F76B400A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SCUKID.
        /// </summary>
        public const string SCUKID = "SCUKID";

        /// <summary>
        /// SCKCO.
        /// </summary>
        public const string SCKCO = "SCKCO";

        /// <summary>
        /// SCFCO.
        /// </summary>
        public const string SCFCO = "SCFCO";

        /// <summary>
        /// SCBSFH.
        /// </summary>
        public const string SCBSFH = "SCBSFH";

        /// <summary>
        /// SCDCT.
        /// </summary>
        public const string SCDCT = "SCDCT";

        /// <summary>
        /// SCLITM.
        /// </summary>
        public const string SCLITM = "SCLITM";

        /// <summary>
        /// SCBRND.
        /// </summary>
        public const string SCBRND = "SCBRND";

        /// <summary>
        /// SCBRSD.
        /// </summary>
        public const string SCBRSD = "SCBRSD";

        /// <summary>
        /// SCBSER.
        /// </summary>
        public const string SCBSER = "SCBSER";

        /// <summary>
        /// SCBRDN.
        /// </summary>
        public const string SCBRDN = "SCBRDN";

        /// <summary>
        /// SCDGL.
        /// </summary>
        public const string SCDGL = "SCDGL";

        /// <summary>
        /// SCTREX.
        /// </summary>
        public const string SCTREX = "SCTREX";

        /// <summary>
        /// SCTRUM.
        /// </summary>
        public const string SCTRUM = "SCTRUM";

        /// <summary>
        /// SCTRQT.
        /// </summary>
        public const string SCTRQT = "SCTRQT";

        /// <summary>
        /// SCBRMI.
        /// </summary>
        public const string SCBRMI = "SCBRMI";

        /// <summary>
        /// SCUNCS.
        /// </summary>
        public const string SCUNCS = "SCUNCS";

        /// <summary>
        /// SCPAID.
        /// </summary>
        public const string SCPAID = "SCPAID";

        /// <summary>
        /// SCMCU.
        /// </summary>
        public const string SCMCU = "SCMCU";

        /// <summary>
        /// SCRDOR.
        /// </summary>
        public const string SCRDOR = "SCRDOR";

        /// <summary>
        /// SCC1FU.
        /// </summary>
        public const string SCC1FU = "SCC1FU";

        /// <summary>
        /// SCC2FU.
        /// </summary>
        public const string SCC2FU = "SCC2FU";

        /// <summary>
        /// SCD1FU.
        /// </summary>
        public const string SCD1FU = "SCD1FU";

        /// <summary>
        /// SCD2FU.
        /// </summary>
        public const string SCD2FU = "SCD2FU";

        /// <summary>
        /// SCN1FU.
        /// </summary>
        public const string SCN1FU = "SCN1FU";

        /// <summary>
        /// SCN2FU.
        /// </summary>
        public const string SCN2FU = "SCN2FU";

        /// <summary>
        /// SCN3FU.
        /// </summary>
        public const string SCN3FU = "SCN3FU";

        /// <summary>
        /// SCN4FU.
        /// </summary>
        public const string SCN4FU = "SCN4FU";

        /// <summary>
        /// SCN5FU.
        /// </summary>
        public const string SCN5FU = "SCN5FU";

        /// <summary>
        /// SCN6FU.
        /// </summary>
        public const string SCN6FU = "SCN6FU";

        /// <summary>
        /// SCN7FU.
        /// </summary>
        public const string SCN7FU = "SCN7FU";

        /// <summary>
        /// SCS1FU.
        /// </summary>
        public const string SCS1FU = "SCS1FU";

        /// <summary>
        /// SCS2FU.
        /// </summary>
        public const string SCS2FU = "SCS2FU";

        /// <summary>
        /// SCS3FU.
        /// </summary>
        public const string SCS3FU = "SCS3FU";

        /// <summary>
        /// SCS4FU.
        /// </summary>
        public const string SCS4FU = "SCS4FU";

        /// <summary>
        /// SCGENLNG.
        /// </summary>
        public const string SCGENLNG = "SCGENLNG";

        /// <summary>
        /// SCTORG.
        /// </summary>
        public const string SCTORG = "SCTORG";

        /// <summary>
        /// SCUSER.
        /// </summary>
        public const string SCUSER = "SCUSER";

        /// <summary>
        /// SCPID.
        /// </summary>
        public const string SCPID = "SCPID";

        /// <summary>
        /// SCJOBN.
        /// </summary>
        public const string SCJOBN = "SCJOBN";

        /// <summary>
        /// SCUPMJ.
        /// </summary>
        public const string SCUPMJ = "SCUPMJ";

        /// <summary>
        /// SCUPMT.
        /// </summary>
        public const string SCUPMT = "SCUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B400A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SCUKID", "SCUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("SCKCO", "SCKCO", JdeDataType.String, 10),
        new JdeField("SCFCO", "SCFCO", JdeDataType.String, 10),
        new JdeField("SCBSFH", "SCBSFH", JdeDataType.Numeric),
        new JdeField("SCDCT", "SCDCT", JdeDataType.String, 4),
        new JdeField("SCLITM", "SCLITM", JdeDataType.String, 50),
        new JdeField("SCBRND", "SCBRND", JdeDataType.String, 2),
        new JdeField("SCBRSD", "SCBRSD", JdeDataType.String, 6),
        new JdeField("SCBSER", "SCBSER", JdeDataType.String, 4),
        new JdeField("SCBRDN", "SCBRDN", JdeDataType.String, 24),
        new JdeField("SCDGL", "SCDGL", JdeDataType.Numeric),
        new JdeField("SCTREX", "SCTREX", JdeDataType.String, 60),
        new JdeField("SCTRUM", "SCTRUM", JdeDataType.String, 4),
        new JdeField("SCTRQT", "SCTRQT", JdeDataType.Numeric),
        new JdeField("SCBRMI", "SCBRMI", JdeDataType.String, 2),
        new JdeField("SCUNCS", "SCUNCS", JdeDataType.Numeric),
        new JdeField("SCPAID", "SCPAID", JdeDataType.Numeric),
        new JdeField("SCMCU", "SCMCU", JdeDataType.String, 24),
        new JdeField("SCRDOR", "SCRDOR", JdeDataType.String, 2),
        new JdeField("SCC1FU", "SCC1FU", JdeDataType.String, 2),
        new JdeField("SCC2FU", "SCC2FU", JdeDataType.String, 2),
        new JdeField("SCD1FU", "SCD1FU", JdeDataType.Numeric),
        new JdeField("SCD2FU", "SCD2FU", JdeDataType.Numeric),
        new JdeField("SCN1FU", "SCN1FU", JdeDataType.Numeric),
        new JdeField("SCN2FU", "SCN2FU", JdeDataType.Numeric),
        new JdeField("SCN3FU", "SCN3FU", JdeDataType.Numeric),
        new JdeField("SCN4FU", "SCN4FU", JdeDataType.Numeric),
        new JdeField("SCN5FU", "SCN5FU", JdeDataType.Numeric),
        new JdeField("SCN6FU", "SCN6FU", JdeDataType.Numeric),
        new JdeField("SCN7FU", "SCN7FU", JdeDataType.Numeric),
        new JdeField("SCS1FU", "SCS1FU", JdeDataType.String, 60),
        new JdeField("SCS2FU", "SCS2FU", JdeDataType.String, 60),
        new JdeField("SCS3FU", "SCS3FU", JdeDataType.String, 6),
        new JdeField("SCS4FU", "SCS4FU", JdeDataType.String, 6),
        new JdeField("SCGENLNG", "SCGENLNG", JdeDataType.Numeric),
        new JdeField("SCTORG", "SCTORG", JdeDataType.String, 20),
        new JdeField("SCUSER", "SCUSER", JdeDataType.String, 20),
        new JdeField("SCPID", "SCPID", JdeDataType.String, 20),
        new JdeField("SCJOBN", "SCJOBN", JdeDataType.String, 20),
        new JdeField("SCUPMJ", "SCUPMJ", JdeDataType.Numeric),
        new JdeField("SCUPMT", "SCUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B400A_0", "Primary Key on SCUKID", new[] { "SCUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76B400A_2", "Unique Index on SCKCO, SCFCO, SCBSFH, SCDCT, SCLITM, SCBRDN, SCBSER, SCBRSD, SCDGL", new[] { "SCKCO", "SCFCO", "SCBSFH", "SCDCT", "SCLITM", "SCBRDN", "SCBSER", "SCBRSD", "SCDGL" }, isUnique: true)
    };
}
