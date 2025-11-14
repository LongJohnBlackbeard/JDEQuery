using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F30UI011 - .
/// </summary>
public class F30UI011 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CCUSER.
        /// </summary>
        public const string CCUSER = "CCUSER";

        /// <summary>
        /// CCPEID.
        /// </summary>
        public const string CCPEID = "CCPEID";

        /// <summary>
        /// CCJOBS.
        /// </summary>
        public const string CCJOBS = "CCJOBS";

        /// <summary>
        /// CCLLX.
        /// </summary>
        public const string CCLLX = "CCLLX";

        /// <summary>
        /// CCCMCU.
        /// </summary>
        public const string CCCMCU = "CCCMCU";

        /// <summary>
        /// CCITM.
        /// </summary>
        public const string CCITM = "CCITM";

        /// <summary>
        /// CCACQ.
        /// </summary>
        public const string CCACQ = "CCACQ";

        /// <summary>
        /// CCBQTY.
        /// </summary>
        public const string CCBQTY = "CCBQTY";

        /// <summary>
        /// CCUOM1.
        /// </summary>
        public const string CCUOM1 = "CCUOM1";

        /// <summary>
        /// CCTFLA.
        /// </summary>
        public const string CCTFLA = "CCTFLA";

        /// <summary>
        /// CCSTKT.
        /// </summary>
        public const string CCSTKT = "CCSTKT";

        /// <summary>
        /// CCSTKTYPE.
        /// </summary>
        public const string CCSTKTYPE = "CCSTKTYPE";

        /// <summary>
        /// CCOT1Y.
        /// </summary>
        public const string CCOT1Y = "CCOT1Y";

        /// <summary>
        /// CCSTDP.
        /// </summary>
        public const string CCSTDP = "CCSTDP";

        /// <summary>
        /// CCCLEV.
        /// </summary>
        public const string CCCLEV = "CCCLEV";

        /// <summary>
        /// CCLITM.
        /// </summary>
        public const string CCLITM = "CCLITM";

        /// <summary>
        /// CCAITM.
        /// </summary>
        public const string CCAITM = "CCAITM";

        /// <summary>
        /// CCBEXP.
        /// </summary>
        public const string CCBEXP = "CCBEXP";

        /// <summary>
        /// CCLLVL.
        /// </summary>
        public const string CCLLVL = "CCLLVL";

        /// <summary>
        /// CCEV01.
        /// </summary>
        public const string CCEV01 = "CCEV01";

        /// <summary>
        /// CCITMR.
        /// </summary>
        public const string CCITMR = "CCITMR";

        /// <summary>
        /// CCCWC.
        /// </summary>
        public const string CCCWC = "CCCWC";
    }

    /// <inheritdoc />
    public override string TableName => "F30UI011";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CCUSER", "CCUSER", JdeDataType.String, 20, true, true),
        new JdeField("CCPEID", "CCPEID", JdeDataType.Numeric, null, true, true),
        new JdeField("CCJOBS", "CCJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("CCLLX", "CCLLX", JdeDataType.Numeric, null, true, true),
        new JdeField("CCCMCU", "CCCMCU", JdeDataType.String, 24, true, true),
        new JdeField("CCITM", "CCITM", JdeDataType.Numeric, null, true, true),
        new JdeField("CCACQ", "CCACQ", JdeDataType.Numeric, null, true, true),
        new JdeField("CCBQTY", "CCBQTY", JdeDataType.Numeric, null, true, true),
        new JdeField("CCUOM1", "CCUOM1", JdeDataType.String, 4),
        new JdeField("CCTFLA", "CCTFLA", JdeDataType.String, 4),
        new JdeField("CCSTKT", "CCSTKT", JdeDataType.String, 2),
        new JdeField("CCSTKTYPE", "CCSTKTYPE", JdeDataType.String, 2),
        new JdeField("CCOT1Y", "CCOT1Y", JdeDataType.String, 2),
        new JdeField("CCSTDP", "CCSTDP", JdeDataType.Numeric),
        new JdeField("CCCLEV", "CCCLEV", JdeDataType.String, 2),
        new JdeField("CCLITM", "CCLITM", JdeDataType.String, 50),
        new JdeField("CCAITM", "CCAITM", JdeDataType.String, 50),
        new JdeField("CCBEXP", "CCBEXP", JdeDataType.String, 2),
        new JdeField("CCLLVL", "CCLLVL", JdeDataType.String, 2),
        new JdeField("CCEV01", "CCEV01", JdeDataType.String, 2),
        new JdeField("CCITMR", "CCITMR", JdeDataType.Numeric),
        new JdeField("CCCWC", "CCCWC", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F30UI011_0", "Primary Key on CCUSER, CCPEID, CCJOBS, CCLLX, CCCMCU, CCITM, CCACQ, CCBQTY", new[] { "CCUSER", "CCPEID", "CCJOBS", "CCLLX", "CCCMCU", "CCITM", "CCACQ", "CCBQTY" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F30UI011_2", "Index on CCUSER, CCPEID, CCJOBS, CCCMCU, CCITM", new[] { "CCUSER", "CCPEID", "CCJOBS", "CCCMCU", "CCITM" }),
        new JdeIndex("F30UI011_3", "Index on CCUSER, CCPEID, CCJOBS, CCCMCU, CCLITM", new[] { "CCUSER", "CCPEID", "CCJOBS", "CCCMCU", "CCLITM" })
    };
}
