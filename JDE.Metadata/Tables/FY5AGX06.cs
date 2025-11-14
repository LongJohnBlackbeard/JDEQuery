using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FY5AGX06 - .
/// </summary>
public class FY5AGX06 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DIRLTYPE.
        /// </summary>
        public const string DIRLTYPE = "DIRLTYPE";

        /// <summary>
        /// DIFRMREL.
        /// </summary>
        public const string DIFRMREL = "DIFRMREL";

        /// <summary>
        /// DITHRREL.
        /// </summary>
        public const string DITHRREL = "DITHRREL";

        /// <summary>
        /// DIPARNTTSK.
        /// </summary>
        public const string DIPARNTTSK = "DIPARNTTSK";

        /// <summary>
        /// DICHILDTSK.
        /// </summary>
        public const string DICHILDTSK = "DICHILDTSK";

        /// <summary>
        /// DIPRSSEQ.
        /// </summary>
        public const string DIPRSSEQ = "DIPRSSEQ";

        /// <summary>
        /// DIRULEID.
        /// </summary>
        public const string DIRULEID = "DIRULEID";

        /// <summary>
        /// DIPARCNGRP.
        /// </summary>
        public const string DIPARCNGRP = "DIPARCNGRP";

        /// <summary>
        /// DIOVHRS.
        /// </summary>
        public const string DIOVHRS = "DIOVHRS";

        /// <summary>
        /// DIOVRSC.
        /// </summary>
        public const string DIOVRSC = "DIOVRSC";

        /// <summary>
        /// DIUNITOFMS.
        /// </summary>
        public const string DIUNITOFMS = "DIUNITOFMS";

        /// <summary>
        /// DIRELACTIVE.
        /// </summary>
        public const string DIRELACTIVE = "DIRELACTIVE";

        /// <summary>
        /// DIREQOPTFG.
        /// </summary>
        public const string DIREQOPTFG = "DIREQOPTFG";

        /// <summary>
        /// DIACTIVAFG.
        /// </summary>
        public const string DIACTIVAFG = "DIACTIVAFG";

        /// <summary>
        /// DIBPMED.
        /// </summary>
        public const string DIBPMED = "DIBPMED";

        /// <summary>
        /// DIBPMR.
        /// </summary>
        public const string DIBPMR = "DIBPMR";

        /// <summary>
        /// DILKRTREL.
        /// </summary>
        public const string DILKRTREL = "DILKRTREL";

        /// <summary>
        /// DILKPTREL.
        /// </summary>
        public const string DILKPTREL = "DILKPTREL";

        /// <summary>
        /// DILKCTREL.
        /// </summary>
        public const string DILKCTREL = "DILKCTREL";

        /// <summary>
        /// DILKFRREL.
        /// </summary>
        public const string DILKFRREL = "DILKFRREL";

        /// <summary>
        /// DILKTRREL.
        /// </summary>
        public const string DILKTRREL = "DILKTRREL";

        /// <summary>
        /// DIDATAPASS.
        /// </summary>
        public const string DIDATAPASS = "DIDATAPASS";

        /// <summary>
        /// DICOMPLETE.
        /// </summary>
        public const string DICOMPLETE = "DICOMPLETE";

        /// <summary>
        /// DIUSER.
        /// </summary>
        public const string DIUSER = "DIUSER";

        /// <summary>
        /// DIPID.
        /// </summary>
        public const string DIPID = "DIPID";

        /// <summary>
        /// DIJOBN.
        /// </summary>
        public const string DIJOBN = "DIJOBN";

        /// <summary>
        /// DIUPMJ.
        /// </summary>
        public const string DIUPMJ = "DIUPMJ";

        /// <summary>
        /// DIUPMT.
        /// </summary>
        public const string DIUPMT = "DIUPMT";

        /// <summary>
        /// DIFUFREL1.
        /// </summary>
        public const string DIFUFREL1 = "DIFUFREL1";

        /// <summary>
        /// DIFUFREL2.
        /// </summary>
        public const string DIFUFREL2 = "DIFUFREL2";

        /// <summary>
        /// DIFUFREL3.
        /// </summary>
        public const string DIFUFREL3 = "DIFUFREL3";

        /// <summary>
        /// DIFUFREL4.
        /// </summary>
        public const string DIFUFREL4 = "DIFUFREL4";

        /// <summary>
        /// DIFUFREL5.
        /// </summary>
        public const string DIFUFREL5 = "DIFUFREL5";

        /// <summary>
        /// DIFUFREL6.
        /// </summary>
        public const string DIFUFREL6 = "DIFUFREL6";

        /// <summary>
        /// DIFUFREL7.
        /// </summary>
        public const string DIFUFREL7 = "DIFUFREL7";

        /// <summary>
        /// DIFUFREL8.
        /// </summary>
        public const string DIFUFREL8 = "DIFUFREL8";
    }

    /// <inheritdoc />
    public override string TableName => "FY5AGX06";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DIRLTYPE", "DIRLTYPE", JdeDataType.String, 10, true, true),
        new JdeField("DIFRMREL", "DIFRMREL", JdeDataType.String, 20, true, true),
        new JdeField("DITHRREL", "DITHRREL", JdeDataType.String, 20, true, true),
        new JdeField("DIPARNTTSK", "DIPARNTTSK", JdeDataType.String, 72, true, true),
        new JdeField("DICHILDTSK", "DICHILDTSK", JdeDataType.String, 72, true, true),
        new JdeField("DIPRSSEQ", "DIPRSSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("DIRULEID", "DIRULEID", JdeDataType.String, 30),
        new JdeField("DIPARCNGRP", "DIPARCNGRP", JdeDataType.Numeric),
        new JdeField("DIOVHRS", "DIOVHRS", JdeDataType.Numeric),
        new JdeField("DIOVRSC", "DIOVRSC", JdeDataType.String, 16),
        new JdeField("DIUNITOFMS", "DIUNITOFMS", JdeDataType.String, 4),
        new JdeField("DIRELACTIVE", "DIRELACTIVE", JdeDataType.String, 2),
        new JdeField("DIREQOPTFG", "DIREQOPTFG", JdeDataType.String, 2),
        new JdeField("DIACTIVAFG", "DIACTIVAFG", JdeDataType.String, 2),
        new JdeField("DIBPMED", "DIBPMED", JdeDataType.String, 80),
        new JdeField("DIBPMR", "DIBPMR", JdeDataType.String, 80),
        new JdeField("DILKRTREL", "DILKRTREL", JdeDataType.String, 10),
        new JdeField("DILKPTREL", "DILKPTREL", JdeDataType.String, 72),
        new JdeField("DILKCTREL", "DILKCTREL", JdeDataType.String, 72),
        new JdeField("DILKFRREL", "DILKFRREL", JdeDataType.String, 20),
        new JdeField("DILKTRREL", "DILKTRREL", JdeDataType.String, 20),
        new JdeField("DIDATAPASS", "DIDATAPASS", JdeDataType.String, 2),
        new JdeField("DICOMPLETE", "DICOMPLETE", JdeDataType.String, 2),
        new JdeField("DIUSER", "DIUSER", JdeDataType.String, 20),
        new JdeField("DIPID", "DIPID", JdeDataType.String, 20),
        new JdeField("DIJOBN", "DIJOBN", JdeDataType.String, 20),
        new JdeField("DIUPMJ", "DIUPMJ", JdeDataType.Numeric),
        new JdeField("DIUPMT", "DIUPMT", JdeDataType.Numeric),
        new JdeField("DIFUFREL1", "DIFUFREL1", JdeDataType.String, 2),
        new JdeField("DIFUFREL2", "DIFUFREL2", JdeDataType.String, 6),
        new JdeField("DIFUFREL3", "DIFUFREL3", JdeDataType.String, 6),
        new JdeField("DIFUFREL4", "DIFUFREL4", JdeDataType.String, 20),
        new JdeField("DIFUFREL5", "DIFUFREL5", JdeDataType.String, 20),
        new JdeField("DIFUFREL6", "DIFUFREL6", JdeDataType.String, 40),
        new JdeField("DIFUFREL7", "DIFUFREL7", JdeDataType.String, 80),
        new JdeField("DIFUFREL8", "DIFUFREL8", JdeDataType.String, 160)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FY5AGX06_0", "Primary Key on DIRLTYPE, DIFRMREL, DITHRREL, DIPARNTTSK, DICHILDTSK, DIPRSSEQ", new[] { "DIRLTYPE", "DIFRMREL", "DITHRREL", "DIPARNTTSK", "DICHILDTSK", "DIPRSSEQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FY5AGX06_2", "Index on DICHILDTSK", new[] { "DICHILDTSK" }),
        new JdeIndex("FY5AGX06_3", "Index on DIRLTYPE, DIFRMREL, DITHRREL, DIPARNTTSK, DIPRSSEQ", new[] { "DIRLTYPE", "DIFRMREL", "DITHRREL", "DIPARNTTSK", "DIPRSSEQ" }),
        new JdeIndex("FY5AGX06_4", "Index on DIRLTYPE, DIPARNTTSK, DICHILDTSK, DIPRSSEQ, DIFRMREL, DITHRREL", new[] { "DIRLTYPE", "DIPARNTTSK", "DICHILDTSK", "DIPRSSEQ", "DIFRMREL", "DITHRREL" }),
        new JdeIndex("FY5AGX06_5", "Index on DIRULEID", new[] { "DIRULEID" }),
        new JdeIndex("FY5AGX06_6", "Index on DIPARNTTSK", new[] { "DIPARNTTSK" }),
        new JdeIndex("FY5AGX06_7", "Index on DIRLTYPE, DICHILDTSK, DIFRMREL, DITHRREL", new[] { "DIRLTYPE", "DICHILDTSK", "DIFRMREL", "DITHRREL" }),
        new JdeIndex("FY5AGX06_8", "Index on DIRELACTIVE, DIPARNTTSK, DICHILDTSK, DIRLTYPE, DIFRMREL, DITHRREL", new[] { "DIRELACTIVE", "DIPARNTTSK", "DICHILDTSK", "DIRLTYPE", "DIFRMREL", "DITHRREL" })
    };
}
