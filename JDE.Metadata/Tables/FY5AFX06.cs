using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FY5AFX06 - .
/// </summary>
public class FY5AFX06 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TRRLTYPE.
        /// </summary>
        public const string TRRLTYPE = "TRRLTYPE";

        /// <summary>
        /// TRFRMREL.
        /// </summary>
        public const string TRFRMREL = "TRFRMREL";

        /// <summary>
        /// TRTHRREL.
        /// </summary>
        public const string TRTHRREL = "TRTHRREL";

        /// <summary>
        /// TRPARNTTSK.
        /// </summary>
        public const string TRPARNTTSK = "TRPARNTTSK";

        /// <summary>
        /// TRCHILDTSK.
        /// </summary>
        public const string TRCHILDTSK = "TRCHILDTSK";

        /// <summary>
        /// TRPRSSEQ.
        /// </summary>
        public const string TRPRSSEQ = "TRPRSSEQ";

        /// <summary>
        /// TRRULEID.
        /// </summary>
        public const string TRRULEID = "TRRULEID";

        /// <summary>
        /// TRPARCNGRP.
        /// </summary>
        public const string TRPARCNGRP = "TRPARCNGRP";

        /// <summary>
        /// TROVHRS.
        /// </summary>
        public const string TROVHRS = "TROVHRS";

        /// <summary>
        /// TROVRSC.
        /// </summary>
        public const string TROVRSC = "TROVRSC";

        /// <summary>
        /// TRUNITOFMS.
        /// </summary>
        public const string TRUNITOFMS = "TRUNITOFMS";

        /// <summary>
        /// TRRELACTIVE.
        /// </summary>
        public const string TRRELACTIVE = "TRRELACTIVE";

        /// <summary>
        /// TRREQOPTFG.
        /// </summary>
        public const string TRREQOPTFG = "TRREQOPTFG";

        /// <summary>
        /// TRACTIVAFG.
        /// </summary>
        public const string TRACTIVAFG = "TRACTIVAFG";

        /// <summary>
        /// TRBPMED.
        /// </summary>
        public const string TRBPMED = "TRBPMED";

        /// <summary>
        /// TRBPMR.
        /// </summary>
        public const string TRBPMR = "TRBPMR";

        /// <summary>
        /// TRLKRTREL.
        /// </summary>
        public const string TRLKRTREL = "TRLKRTREL";

        /// <summary>
        /// TRLKPTREL.
        /// </summary>
        public const string TRLKPTREL = "TRLKPTREL";

        /// <summary>
        /// TRLKCTREL.
        /// </summary>
        public const string TRLKCTREL = "TRLKCTREL";

        /// <summary>
        /// TRLKFRREL.
        /// </summary>
        public const string TRLKFRREL = "TRLKFRREL";

        /// <summary>
        /// TRLKTRREL.
        /// </summary>
        public const string TRLKTRREL = "TRLKTRREL";

        /// <summary>
        /// TRDATAPASS.
        /// </summary>
        public const string TRDATAPASS = "TRDATAPASS";

        /// <summary>
        /// TRCOMPLETE.
        /// </summary>
        public const string TRCOMPLETE = "TRCOMPLETE";

        /// <summary>
        /// TRUSER.
        /// </summary>
        public const string TRUSER = "TRUSER";

        /// <summary>
        /// TRPID.
        /// </summary>
        public const string TRPID = "TRPID";

        /// <summary>
        /// TRJOBN.
        /// </summary>
        public const string TRJOBN = "TRJOBN";

        /// <summary>
        /// TRUPMJ.
        /// </summary>
        public const string TRUPMJ = "TRUPMJ";

        /// <summary>
        /// TRUPMT.
        /// </summary>
        public const string TRUPMT = "TRUPMT";

        /// <summary>
        /// TRFUFREL1.
        /// </summary>
        public const string TRFUFREL1 = "TRFUFREL1";

        /// <summary>
        /// TRFUFREL2.
        /// </summary>
        public const string TRFUFREL2 = "TRFUFREL2";

        /// <summary>
        /// TRFUFREL3.
        /// </summary>
        public const string TRFUFREL3 = "TRFUFREL3";

        /// <summary>
        /// TRFUFREL4.
        /// </summary>
        public const string TRFUFREL4 = "TRFUFREL4";

        /// <summary>
        /// TRFUFREL5.
        /// </summary>
        public const string TRFUFREL5 = "TRFUFREL5";

        /// <summary>
        /// TRFUFREL6.
        /// </summary>
        public const string TRFUFREL6 = "TRFUFREL6";

        /// <summary>
        /// TRFUFREL7.
        /// </summary>
        public const string TRFUFREL7 = "TRFUFREL7";

        /// <summary>
        /// TRFUFREL8.
        /// </summary>
        public const string TRFUFREL8 = "TRFUFREL8";

        /// <summary>
        /// TRSY.
        /// </summary>
        public const string TRSY = "TRSY";
    }

    /// <inheritdoc />
    public override string TableName => "FY5AFX06";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TRRLTYPE", "TRRLTYPE", JdeDataType.String, 10, true, true),
        new JdeField("TRFRMREL", "TRFRMREL", JdeDataType.String, 20, true, true),
        new JdeField("TRTHRREL", "TRTHRREL", JdeDataType.String, 20, true, true),
        new JdeField("TRPARNTTSK", "TRPARNTTSK", JdeDataType.String, 72, true, true),
        new JdeField("TRCHILDTSK", "TRCHILDTSK", JdeDataType.String, 72, true, true),
        new JdeField("TRPRSSEQ", "TRPRSSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("TRRULEID", "TRRULEID", JdeDataType.String, 30),
        new JdeField("TRPARCNGRP", "TRPARCNGRP", JdeDataType.Numeric),
        new JdeField("TROVHRS", "TROVHRS", JdeDataType.Numeric),
        new JdeField("TROVRSC", "TROVRSC", JdeDataType.String, 16),
        new JdeField("TRUNITOFMS", "TRUNITOFMS", JdeDataType.String, 4),
        new JdeField("TRRELACTIVE", "TRRELACTIVE", JdeDataType.String, 2),
        new JdeField("TRREQOPTFG", "TRREQOPTFG", JdeDataType.String, 2),
        new JdeField("TRACTIVAFG", "TRACTIVAFG", JdeDataType.String, 2),
        new JdeField("TRBPMED", "TRBPMED", JdeDataType.String, 80),
        new JdeField("TRBPMR", "TRBPMR", JdeDataType.String, 80),
        new JdeField("TRLKRTREL", "TRLKRTREL", JdeDataType.String, 10),
        new JdeField("TRLKPTREL", "TRLKPTREL", JdeDataType.String, 72),
        new JdeField("TRLKCTREL", "TRLKCTREL", JdeDataType.String, 72),
        new JdeField("TRLKFRREL", "TRLKFRREL", JdeDataType.String, 20),
        new JdeField("TRLKTRREL", "TRLKTRREL", JdeDataType.String, 20),
        new JdeField("TRDATAPASS", "TRDATAPASS", JdeDataType.String, 2),
        new JdeField("TRCOMPLETE", "TRCOMPLETE", JdeDataType.String, 2),
        new JdeField("TRUSER", "TRUSER", JdeDataType.String, 20),
        new JdeField("TRPID", "TRPID", JdeDataType.String, 20),
        new JdeField("TRJOBN", "TRJOBN", JdeDataType.String, 20),
        new JdeField("TRUPMJ", "TRUPMJ", JdeDataType.Numeric),
        new JdeField("TRUPMT", "TRUPMT", JdeDataType.Numeric),
        new JdeField("TRFUFREL1", "TRFUFREL1", JdeDataType.String, 2),
        new JdeField("TRFUFREL2", "TRFUFREL2", JdeDataType.String, 6),
        new JdeField("TRFUFREL3", "TRFUFREL3", JdeDataType.String, 6),
        new JdeField("TRFUFREL4", "TRFUFREL4", JdeDataType.String, 20),
        new JdeField("TRFUFREL5", "TRFUFREL5", JdeDataType.String, 20),
        new JdeField("TRFUFREL6", "TRFUFREL6", JdeDataType.String, 40),
        new JdeField("TRFUFREL7", "TRFUFREL7", JdeDataType.String, 80),
        new JdeField("TRFUFREL8", "TRFUFREL8", JdeDataType.String, 160),
        new JdeField("TRSY", "TRSY", JdeDataType.String, 8)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FY5AFX06_0", "Primary Key on TRRLTYPE, TRFRMREL, TRTHRREL, TRPARNTTSK, TRCHILDTSK, TRPRSSEQ", new[] { "TRRLTYPE", "TRFRMREL", "TRTHRREL", "TRPARNTTSK", "TRCHILDTSK", "TRPRSSEQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FY5AFX06_2", "Index on TRCHILDTSK", new[] { "TRCHILDTSK" }),
        new JdeIndex("FY5AFX06_3", "Index on TRRLTYPE, TRFRMREL, TRTHRREL, TRPARNTTSK, TRPRSSEQ", new[] { "TRRLTYPE", "TRFRMREL", "TRTHRREL", "TRPARNTTSK", "TRPRSSEQ" }),
        new JdeIndex("FY5AFX06_4", "Index on TRRLTYPE, TRPARNTTSK, TRCHILDTSK, TRPRSSEQ, TRFRMREL, TRTHRREL", new[] { "TRRLTYPE", "TRPARNTTSK", "TRCHILDTSK", "TRPRSSEQ", "TRFRMREL", "TRTHRREL" }),
        new JdeIndex("FY5AFX06_5", "Index on TRRULEID", new[] { "TRRULEID" }),
        new JdeIndex("FY5AFX06_6", "Index on TRPARNTTSK", new[] { "TRPARNTTSK" }),
        new JdeIndex("FY5AFX06_7", "Index on TRRLTYPE, TRCHILDTSK, TRFRMREL, TRTHRREL", new[] { "TRRLTYPE", "TRCHILDTSK", "TRFRMREL", "TRTHRREL" }),
        new JdeIndex("FY5AFX06_8", "Index on TRRELACTIVE, TRPARNTTSK, TRCHILDTSK, TRRLTYPE, TRFRMREL, TRTHRREL", new[] { "TRRELACTIVE", "TRPARNTTSK", "TRCHILDTSK", "TRRLTYPE", "TRFRMREL", "TRTHRREL" }),
        new JdeIndex("FY5AFX06_9", "Index on TRSY", new[] { "TRSY" })
    };
}
