using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40334 - .
/// </summary>
public class F40334 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MTAN8.
        /// </summary>
        public const string MTAN8 = "MTAN8";

        /// <summary>
        /// MTCS34.
        /// </summary>
        public const string MTCS34 = "MTCS34";

        /// <summary>
        /// MTITM.
        /// </summary>
        public const string MTITM = "MTITM";

        /// <summary>
        /// MTIT84.
        /// </summary>
        public const string MTIT84 = "MTIT84";

        /// <summary>
        /// MTEFTJ.
        /// </summary>
        public const string MTEFTJ = "MTEFTJ";

        /// <summary>
        /// MTEXDJ.
        /// </summary>
        public const string MTEXDJ = "MTEXDJ";

        /// <summary>
        /// MTMNQ.
        /// </summary>
        public const string MTMNQ = "MTMNQ";

        /// <summary>
        /// MTMXQ.
        /// </summary>
        public const string MTMXQ = "MTMXQ";

        /// <summary>
        /// MTUOM.
        /// </summary>
        public const string MTUOM = "MTUOM";

        /// <summary>
        /// MTTXID.
        /// </summary>
        public const string MTTXID = "MTTXID";

        /// <summary>
        /// MTSTPR.
        /// </summary>
        public const string MTSTPR = "MTSTPR";

        /// <summary>
        /// MTOSEQ.
        /// </summary>
        public const string MTOSEQ = "MTOSEQ";

        /// <summary>
        /// MTMCU.
        /// </summary>
        public const string MTMCU = "MTMCU";

        /// <summary>
        /// MTORGN.
        /// </summary>
        public const string MTORGN = "MTORGN";

        /// <summary>
        /// MTCTY1.
        /// </summary>
        public const string MTCTY1 = "MTCTY1";

        /// <summary>
        /// MTADDS.
        /// </summary>
        public const string MTADDS = "MTADDS";

        /// <summary>
        /// MTZON.
        /// </summary>
        public const string MTZON = "MTZON";

        /// <summary>
        /// MTZTO.
        /// </summary>
        public const string MTZTO = "MTZTO";

        /// <summary>
        /// MTZTH.
        /// </summary>
        public const string MTZTH = "MTZTH";

        /// <summary>
        /// MTFRTH.
        /// </summary>
        public const string MTFRTH = "MTFRTH";

        /// <summary>
        /// MTCTR.
        /// </summary>
        public const string MTCTR = "MTCTR";

        /// <summary>
        /// MTMOT.
        /// </summary>
        public const string MTMOT = "MTMOT";

        /// <summary>
        /// MTURCD.
        /// </summary>
        public const string MTURCD = "MTURCD";

        /// <summary>
        /// MTURDT.
        /// </summary>
        public const string MTURDT = "MTURDT";

        /// <summary>
        /// MTURAT.
        /// </summary>
        public const string MTURAT = "MTURAT";

        /// <summary>
        /// MTURAB.
        /// </summary>
        public const string MTURAB = "MTURAB";

        /// <summary>
        /// MTURRF.
        /// </summary>
        public const string MTURRF = "MTURRF";

        /// <summary>
        /// MTUSER.
        /// </summary>
        public const string MTUSER = "MTUSER";

        /// <summary>
        /// MTPID.
        /// </summary>
        public const string MTPID = "MTPID";

        /// <summary>
        /// MTJOBN.
        /// </summary>
        public const string MTJOBN = "MTJOBN";

        /// <summary>
        /// MTUPMJ.
        /// </summary>
        public const string MTUPMJ = "MTUPMJ";

        /// <summary>
        /// MTTDAY.
        /// </summary>
        public const string MTTDAY = "MTTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F40334";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MTAN8", "MTAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("MTCS34", "MTCS34", JdeDataType.String, 16, true, true),
        new JdeField("MTITM", "MTITM", JdeDataType.Numeric, null, true, true),
        new JdeField("MTIT84", "MTIT84", JdeDataType.String, 16, true, true),
        new JdeField("MTEFTJ", "MTEFTJ", JdeDataType.Numeric),
        new JdeField("MTEXDJ", "MTEXDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("MTMNQ", "MTMNQ", JdeDataType.Numeric),
        new JdeField("MTMXQ", "MTMXQ", JdeDataType.Numeric, null, true, true),
        new JdeField("MTUOM", "MTUOM", JdeDataType.String, 4, true, true),
        new JdeField("MTTXID", "MTTXID", JdeDataType.Numeric),
        new JdeField("MTSTPR", "MTSTPR", JdeDataType.String, 2),
        new JdeField("MTOSEQ", "MTOSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("MTMCU", "MTMCU", JdeDataType.String, 24),
        new JdeField("MTORGN", "MTORGN", JdeDataType.Numeric),
        new JdeField("MTCTY1", "MTCTY1", JdeDataType.String, 50),
        new JdeField("MTADDS", "MTADDS", JdeDataType.String, 6),
        new JdeField("MTZON", "MTZON", JdeDataType.String, 6),
        new JdeField("MTZTO", "MTZTO", JdeDataType.String, 24),
        new JdeField("MTZTH", "MTZTH", JdeDataType.String, 24),
        new JdeField("MTFRTH", "MTFRTH", JdeDataType.String, 6),
        new JdeField("MTCTR", "MTCTR", JdeDataType.String, 6),
        new JdeField("MTMOT", "MTMOT", JdeDataType.String, 6),
        new JdeField("MTURCD", "MTURCD", JdeDataType.String, 4),
        new JdeField("MTURDT", "MTURDT", JdeDataType.Numeric),
        new JdeField("MTURAT", "MTURAT", JdeDataType.Numeric),
        new JdeField("MTURAB", "MTURAB", JdeDataType.Numeric),
        new JdeField("MTURRF", "MTURRF", JdeDataType.String, 30),
        new JdeField("MTUSER", "MTUSER", JdeDataType.String, 20),
        new JdeField("MTPID", "MTPID", JdeDataType.String, 20),
        new JdeField("MTJOBN", "MTJOBN", JdeDataType.String, 20),
        new JdeField("MTUPMJ", "MTUPMJ", JdeDataType.Numeric),
        new JdeField("MTTDAY", "MTTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40334_0", "Primary Key on MTAN8, MTCS34, MTITM, MTIT84, MTEXDJ, MTUOM, MTMXQ, MTOSEQ", new[] { "MTAN8", "MTCS34", "MTITM", "MTIT84", "MTEXDJ", "MTUOM", "MTMXQ", "MTOSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
