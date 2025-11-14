using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F46LUI01 - .
/// </summary>
public class F46LUI01 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WFUKID.
        /// </summary>
        public const string WFUKID = "WFUKID";

        /// <summary>
        /// WFJOBS.
        /// </summary>
        public const string WFJOBS = "WFJOBS";

        /// <summary>
        /// WFMCU.
        /// </summary>
        public const string WFMCU = "WFMCU";

        /// <summary>
        /// WFITM.
        /// </summary>
        public const string WFITM = "WFITM";

        /// <summary>
        /// WFLITM.
        /// </summary>
        public const string WFLITM = "WFLITM";

        /// <summary>
        /// WFAITM.
        /// </summary>
        public const string WFAITM = "WFAITM";

        /// <summary>
        /// WFDSC1.
        /// </summary>
        public const string WFDSC1 = "WFDSC1";

        /// <summary>
        /// WFDSC2.
        /// </summary>
        public const string WFDSC2 = "WFDSC2";

        /// <summary>
        /// WFLOCN.
        /// </summary>
        public const string WFLOCN = "WFLOCN";

        /// <summary>
        /// WFLOTN.
        /// </summary>
        public const string WFLOTN = "WFLOTN";

        /// <summary>
        /// WFCHAR.
        /// </summary>
        public const string WFCHAR = "WFCHAR";

        /// <summary>
        /// WFLPNU.
        /// </summary>
        public const string WFLPNU = "WFLPNU";

        /// <summary>
        /// WFUOM1.
        /// </summary>
        public const string WFUOM1 = "WFUOM1";

        /// <summary>
        /// WFPQOH.
        /// </summary>
        public const string WFPQOH = "WFPQOH";

        /// <summary>
        /// WFDQTY.
        /// </summary>
        public const string WFDQTY = "WFDQTY";

        /// <summary>
        /// WFUOM2.
        /// </summary>
        public const string WFUOM2 = "WFUOM2";

        /// <summary>
        /// WFUORG.
        /// </summary>
        public const string WFUORG = "WFUORG";

        /// <summary>
        /// WFUOM.
        /// </summary>
        public const string WFUOM = "WFUOM";

        /// <summary>
        /// WFTDQTY.
        /// </summary>
        public const string WFTDQTY = "WFTDQTY";

        /// <summary>
        /// WFUOM10.
        /// </summary>
        public const string WFUOM10 = "WFUOM10";

        /// <summary>
        /// WFLRCJ.
        /// </summary>
        public const string WFLRCJ = "WFLRCJ";

        /// <summary>
        /// WFLOTS.
        /// </summary>
        public const string WFLOTS = "WFLOTS";

        /// <summary>
        /// WFMMEJ.
        /// </summary>
        public const string WFMMEJ = "WFMMEJ";

        /// <summary>
        /// WFDOCO.
        /// </summary>
        public const string WFDOCO = "WFDOCO";

        /// <summary>
        /// WFKCOO.
        /// </summary>
        public const string WFKCOO = "WFKCOO";

        /// <summary>
        /// WFDCTO.
        /// </summary>
        public const string WFDCTO = "WFDCTO";

        /// <summary>
        /// WFLNID.
        /// </summary>
        public const string WFLNID = "WFLNID";

        /// <summary>
        /// WFNLIN.
        /// </summary>
        public const string WFNLIN = "WFNLIN";

        /// <summary>
        /// WFSFXO.
        /// </summary>
        public const string WFSFXO = "WFSFXO";

        /// <summary>
        /// WFAN8.
        /// </summary>
        public const string WFAN8 = "WFAN8";

        /// <summary>
        /// WFSHAN.
        /// </summary>
        public const string WFSHAN = "WFSHAN";

        /// <summary>
        /// WFSTKT.
        /// </summary>
        public const string WFSTKT = "WFSTKT";

        /// <summary>
        /// WFLNTY.
        /// </summary>
        public const string WFLNTY = "WFLNTY";

        /// <summary>
        /// WFLCOD.
        /// </summary>
        public const string WFLCOD = "WFLCOD";

        /// <summary>
        /// WFPACK.
        /// </summary>
        public const string WFPACK = "WFPACK";

        /// <summary>
        /// WFRPCK.
        /// </summary>
        public const string WFRPCK = "WFRPCK";

        /// <summary>
        /// WFRCDJ.
        /// </summary>
        public const string WFRCDJ = "WFRCDJ";

        /// <summary>
        /// WFDRQJ.
        /// </summary>
        public const string WFDRQJ = "WFDRQJ";

        /// <summary>
        /// WFTRDJ.
        /// </summary>
        public const string WFTRDJ = "WFTRDJ";

        /// <summary>
        /// WFLTTR.
        /// </summary>
        public const string WFLTTR = "WFLTTR";

        /// <summary>
        /// WFPRP6.
        /// </summary>
        public const string WFPRP6 = "WFPRP6";

        /// <summary>
        /// WFTFLA.
        /// </summary>
        public const string WFTFLA = "WFTFLA";

        /// <summary>
        /// WFDUAL.
        /// </summary>
        public const string WFDUAL = "WFDUAL";

        /// <summary>
        /// WFDPPO.
        /// </summary>
        public const string WFDPPO = "WFDPPO";

        /// <summary>
        /// WFPID.
        /// </summary>
        public const string WFPID = "WFPID";

        /// <summary>
        /// WFFRTO.
        /// </summary>
        public const string WFFRTO = "WFFRTO";
    }

    /// <inheritdoc />
    public override string TableName => "F46LUI01";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WFUKID", "WFUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("WFJOBS", "WFJOBS", JdeDataType.Numeric),
        new JdeField("WFMCU", "WFMCU", JdeDataType.String, 24),
        new JdeField("WFITM", "WFITM", JdeDataType.Numeric),
        new JdeField("WFLITM", "WFLITM", JdeDataType.String, 50),
        new JdeField("WFAITM", "WFAITM", JdeDataType.String, 50),
        new JdeField("WFDSC1", "WFDSC1", JdeDataType.String, 60),
        new JdeField("WFDSC2", "WFDSC2", JdeDataType.String, 60),
        new JdeField("WFLOCN", "WFLOCN", JdeDataType.String, 40),
        new JdeField("WFLOTN", "WFLOTN", JdeDataType.String, 60),
        new JdeField("WFCHAR", "WFCHAR", JdeDataType.String, 2),
        new JdeField("WFLPNU", "WFLPNU", JdeDataType.String, 80),
        new JdeField("WFUOM1", "WFUOM1", JdeDataType.String, 4),
        new JdeField("WFPQOH", "WFPQOH", JdeDataType.Numeric),
        new JdeField("WFDQTY", "WFDQTY", JdeDataType.Numeric),
        new JdeField("WFUOM2", "WFUOM2", JdeDataType.String, 4),
        new JdeField("WFUORG", "WFUORG", JdeDataType.Numeric),
        new JdeField("WFUOM", "WFUOM", JdeDataType.String, 4),
        new JdeField("WFTDQTY", "WFTDQTY", JdeDataType.Numeric),
        new JdeField("WFUOM10", "WFUOM10", JdeDataType.String, 4),
        new JdeField("WFLRCJ", "WFLRCJ", JdeDataType.Numeric),
        new JdeField("WFLOTS", "WFLOTS", JdeDataType.String, 2),
        new JdeField("WFMMEJ", "WFMMEJ", JdeDataType.Numeric),
        new JdeField("WFDOCO", "WFDOCO", JdeDataType.Numeric),
        new JdeField("WFKCOO", "WFKCOO", JdeDataType.String, 10),
        new JdeField("WFDCTO", "WFDCTO", JdeDataType.String, 4),
        new JdeField("WFLNID", "WFLNID", JdeDataType.Numeric),
        new JdeField("WFNLIN", "WFNLIN", JdeDataType.Numeric),
        new JdeField("WFSFXO", "WFSFXO", JdeDataType.String, 6),
        new JdeField("WFAN8", "WFAN8", JdeDataType.Numeric),
        new JdeField("WFSHAN", "WFSHAN", JdeDataType.Numeric),
        new JdeField("WFSTKT", "WFSTKT", JdeDataType.String, 2),
        new JdeField("WFLNTY", "WFLNTY", JdeDataType.String, 4),
        new JdeField("WFLCOD", "WFLCOD", JdeDataType.String, 4),
        new JdeField("WFPACK", "WFPACK", JdeDataType.String, 8),
        new JdeField("WFRPCK", "WFRPCK", JdeDataType.String, 2),
        new JdeField("WFRCDJ", "WFRCDJ", JdeDataType.Numeric),
        new JdeField("WFDRQJ", "WFDRQJ", JdeDataType.Numeric),
        new JdeField("WFTRDJ", "WFTRDJ", JdeDataType.Numeric),
        new JdeField("WFLTTR", "WFLTTR", JdeDataType.String, 6),
        new JdeField("WFPRP6", "WFPRP6", JdeDataType.String, 12),
        new JdeField("WFTFLA", "WFTFLA", JdeDataType.String, 4),
        new JdeField("WFDUAL", "WFDUAL", JdeDataType.String, 2),
        new JdeField("WFDPPO", "WFDPPO", JdeDataType.String, 2),
        new JdeField("WFPID", "WFPID", JdeDataType.String, 20),
        new JdeField("WFFRTO", "WFFRTO", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F46LUI01_0", "Primary Key on WFUKID", new[] { "WFUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F46LUI01_4", "Index on WFJOBS, WFCHAR", new[] { "WFJOBS", "WFCHAR" }),
        new JdeIndex("F46LUI01_5", "Index on WFJOBS, WFCHAR, WFITM, WFMCU, WFLOCN, WFLOTN", new[] { "WFJOBS", "WFCHAR", "WFITM", "WFMCU", "WFLOCN", "WFLOTN" })
    };
}
