using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0116 - .
/// </summary>
public class F0116 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ALAN8.
        /// </summary>
        public const string ALAN8 = "ALAN8";

        /// <summary>
        /// ALEFTB.
        /// </summary>
        public const string ALEFTB = "ALEFTB";

        /// <summary>
        /// ALEFTF.
        /// </summary>
        public const string ALEFTF = "ALEFTF";

        /// <summary>
        /// ALADD1.
        /// </summary>
        public const string ALADD1 = "ALADD1";

        /// <summary>
        /// ALADD2.
        /// </summary>
        public const string ALADD2 = "ALADD2";

        /// <summary>
        /// ALADD3.
        /// </summary>
        public const string ALADD3 = "ALADD3";

        /// <summary>
        /// ALADD4.
        /// </summary>
        public const string ALADD4 = "ALADD4";

        /// <summary>
        /// ALADDZ.
        /// </summary>
        public const string ALADDZ = "ALADDZ";

        /// <summary>
        /// ALCTY1.
        /// </summary>
        public const string ALCTY1 = "ALCTY1";

        /// <summary>
        /// ALCOUN.
        /// </summary>
        public const string ALCOUN = "ALCOUN";

        /// <summary>
        /// ALADDS.
        /// </summary>
        public const string ALADDS = "ALADDS";

        /// <summary>
        /// ALCRTE.
        /// </summary>
        public const string ALCRTE = "ALCRTE";

        /// <summary>
        /// ALBKML.
        /// </summary>
        public const string ALBKML = "ALBKML";

        /// <summary>
        /// ALCTR.
        /// </summary>
        public const string ALCTR = "ALCTR";

        /// <summary>
        /// ALUSER.
        /// </summary>
        public const string ALUSER = "ALUSER";

        /// <summary>
        /// ALPID.
        /// </summary>
        public const string ALPID = "ALPID";

        /// <summary>
        /// ALUPMJ.
        /// </summary>
        public const string ALUPMJ = "ALUPMJ";

        /// <summary>
        /// ALJOBN.
        /// </summary>
        public const string ALJOBN = "ALJOBN";

        /// <summary>
        /// ALUPMT.
        /// </summary>
        public const string ALUPMT = "ALUPMT";

        /// <summary>
        /// ALSYNCS.
        /// </summary>
        public const string ALSYNCS = "ALSYNCS";

        /// <summary>
        /// ALCAAD.
        /// </summary>
        public const string ALCAAD = "ALCAAD";
    }

    /// <inheritdoc />
    public override string TableName => "F0116";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ALAN8", "ALAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("ALEFTB", "ALEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("ALEFTF", "ALEFTF", JdeDataType.String, 2),
        new JdeField("ALADD1", "ALADD1", JdeDataType.String, 80),
        new JdeField("ALADD2", "ALADD2", JdeDataType.String, 80),
        new JdeField("ALADD3", "ALADD3", JdeDataType.String, 80),
        new JdeField("ALADD4", "ALADD4", JdeDataType.String, 80),
        new JdeField("ALADDZ", "ALADDZ", JdeDataType.String, 24),
        new JdeField("ALCTY1", "ALCTY1", JdeDataType.String, 50),
        new JdeField("ALCOUN", "ALCOUN", JdeDataType.String, 50),
        new JdeField("ALADDS", "ALADDS", JdeDataType.String, 6),
        new JdeField("ALCRTE", "ALCRTE", JdeDataType.String, 8),
        new JdeField("ALBKML", "ALBKML", JdeDataType.String, 4),
        new JdeField("ALCTR", "ALCTR", JdeDataType.String, 6),
        new JdeField("ALUSER", "ALUSER", JdeDataType.String, 20),
        new JdeField("ALPID", "ALPID", JdeDataType.String, 20),
        new JdeField("ALUPMJ", "ALUPMJ", JdeDataType.Numeric),
        new JdeField("ALJOBN", "ALJOBN", JdeDataType.String, 20),
        new JdeField("ALUPMT", "ALUPMT", JdeDataType.Numeric),
        new JdeField("ALSYNCS", "ALSYNCS", JdeDataType.Numeric),
        new JdeField("ALCAAD", "ALCAAD", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0116_0", "Primary Key on ALAN8, ALEFTB", new[] { "ALAN8", "ALEFTB" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0116_2", "Index on ALAN8, SYS_NC00022$", new[] { "ALAN8", "SYS_NC00022$" })
    };
}
