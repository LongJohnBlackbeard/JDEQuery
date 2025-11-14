using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F46R020 - .
/// </summary>
public class F46R020 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EMEFFDATE.
        /// </summary>
        public const string EMEFFDATE = "EMEFFDATE";

        /// <summary>
        /// EMEPCHDR.
        /// </summary>
        public const string EMEPCHDR = "EMEPCHDR";

        /// <summary>
        /// EMEPCREF.
        /// </summary>
        public const string EMEPCREF = "EMEPCREF";

        /// <summary>
        /// EMEPCMLV.
        /// </summary>
        public const string EMEPCMLV = "EMEPCMLV";

        /// <summary>
        /// EMEPCMGR.
        /// </summary>
        public const string EMEPCMGR = "EMEPCMGR";

        /// <summary>
        /// EMMGRGRP.
        /// </summary>
        public const string EMMGRGRP = "EMMGRGRP";

        /// <summary>
        /// EMPARGRP.
        /// </summary>
        public const string EMPARGRP = "EMPARGRP";

        /// <summary>
        /// EMURCD.
        /// </summary>
        public const string EMURCD = "EMURCD";

        /// <summary>
        /// EMURDT.
        /// </summary>
        public const string EMURDT = "EMURDT";

        /// <summary>
        /// EMURRF.
        /// </summary>
        public const string EMURRF = "EMURRF";

        /// <summary>
        /// EMDTECRT.
        /// </summary>
        public const string EMDTECRT = "EMDTECRT";

        /// <summary>
        /// EMUPMJ.
        /// </summary>
        public const string EMUPMJ = "EMUPMJ";

        /// <summary>
        /// EMTDAY.
        /// </summary>
        public const string EMTDAY = "EMTDAY";

        /// <summary>
        /// EMUSER.
        /// </summary>
        public const string EMUSER = "EMUSER";

        /// <summary>
        /// EMPID.
        /// </summary>
        public const string EMPID = "EMPID";

        /// <summary>
        /// EMCTID.
        /// </summary>
        public const string EMCTID = "EMCTID";

        /// <summary>
        /// EMSVRNAME.
        /// </summary>
        public const string EMSVRNAME = "EMSVRNAME";
    }

    /// <inheritdoc />
    public override string TableName => "F46R020";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EMEFFDATE", "EMEFFDATE", JdeDataType.Numeric, null, true, true),
        new JdeField("EMEPCHDR", "EMEPCHDR", JdeDataType.String, 4, true, true),
        new JdeField("EMEPCREF", "EMEPCREF", JdeDataType.String, 30, true, true),
        new JdeField("EMEPCMLV", "EMEPCMLV", JdeDataType.String, 4),
        new JdeField("EMEPCMGR", "EMEPCMGR", JdeDataType.String, 40),
        new JdeField("EMMGRGRP", "EMMGRGRP", JdeDataType.String, 20),
        new JdeField("EMPARGRP", "EMPARGRP", JdeDataType.String, 20),
        new JdeField("EMURCD", "EMURCD", JdeDataType.String, 4),
        new JdeField("EMURDT", "EMURDT", JdeDataType.Numeric),
        new JdeField("EMURRF", "EMURRF", JdeDataType.String, 30),
        new JdeField("EMDTECRT", "EMDTECRT", JdeDataType.Numeric),
        new JdeField("EMUPMJ", "EMUPMJ", JdeDataType.Numeric),
        new JdeField("EMTDAY", "EMTDAY", JdeDataType.Numeric),
        new JdeField("EMUSER", "EMUSER", JdeDataType.String, 20),
        new JdeField("EMPID", "EMPID", JdeDataType.String, 20),
        new JdeField("EMCTID", "EMCTID", JdeDataType.String, 30),
        new JdeField("EMSVRNAME", "EMSVRNAME", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F46R020_0", "Primary Key on EMEFFDATE, EMEPCHDR, EMEPCREF", new[] { "EMEFFDATE", "EMEPCHDR", "EMEPCREF" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F46R020_4", "Index on EMEFFDATE, EMEPCHDR, EMEPCMGR", new[] { "EMEFFDATE", "EMEPCHDR", "EMEPCMGR" }),
        new JdeIndex("F46R020_5", "Index on EMEPCHDR, EMEPCREF, EMEPCMLV", new[] { "EMEPCHDR", "EMEPCREF", "EMEPCMLV" }),
        new JdeIndex("F46R020_6", "Index on EMEPCHDR, EMEPCMGR", new[] { "EMEPCHDR", "EMEPCMGR" })
    };
}
