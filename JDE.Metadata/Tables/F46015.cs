using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F46015 - .
/// </summary>
public class F46015 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RRMCU.
        /// </summary>
        public const string RRMCU = "RRMCU";

        /// <summary>
        /// RRSRUL.
        /// </summary>
        public const string RRSRUL = "RRSRUL";

        /// <summary>
        /// RRZTYP.
        /// </summary>
        public const string RRZTYP = "RRZTYP";

        /// <summary>
        /// RRGZON.
        /// </summary>
        public const string RRGZON = "RRGZON";

        /// <summary>
        /// RROGRP.
        /// </summary>
        public const string RROGRP = "RROGRP";

        /// <summary>
        /// RRPRP7.
        /// </summary>
        public const string RRPRP7 = "RRPRP7";

        /// <summary>
        /// RRPRP8.
        /// </summary>
        public const string RRPRP8 = "RRPRP8";

        /// <summary>
        /// RRPRP9.
        /// </summary>
        public const string RRPRP9 = "RRPRP9";

        /// <summary>
        /// RRITM.
        /// </summary>
        public const string RRITM = "RRITM";

        /// <summary>
        /// RRUOM.
        /// </summary>
        public const string RRUOM = "RRUOM";

        /// <summary>
        /// RRMXRR.
        /// </summary>
        public const string RRMXRR = "RRMXRR";

        /// <summary>
        /// RRLETN.
        /// </summary>
        public const string RRLETN = "RRLETN";

        /// <summary>
        /// RRLETM.
        /// </summary>
        public const string RRLETM = "RRLETM";

        /// <summary>
        /// RRIQM.
        /// </summary>
        public const string RRIQM = "RRIQM";

        /// <summary>
        /// RRMBUM.
        /// </summary>
        public const string RRMBUM = "RRMBUM";

        /// <summary>
        /// RRAYN.
        /// </summary>
        public const string RRAYN = "RRAYN";

        /// <summary>
        /// RREF1.
        /// </summary>
        public const string RREF1 = "RREF1";

        /// <summary>
        /// RRET1.
        /// </summary>
        public const string RRET1 = "RRET1";

        /// <summary>
        /// RRUSER.
        /// </summary>
        public const string RRUSER = "RRUSER";

        /// <summary>
        /// RRPID.
        /// </summary>
        public const string RRPID = "RRPID";

        /// <summary>
        /// RRUPMJ.
        /// </summary>
        public const string RRUPMJ = "RRUPMJ";

        /// <summary>
        /// RRTDAY.
        /// </summary>
        public const string RRTDAY = "RRTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F46015";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RRMCU", "RRMCU", JdeDataType.String, 24, true, true),
        new JdeField("RRSRUL", "RRSRUL", JdeDataType.String, 12, true, true),
        new JdeField("RRZTYP", "RRZTYP", JdeDataType.String, 2, true, true),
        new JdeField("RRGZON", "RRGZON", JdeDataType.String, 12, true, true),
        new JdeField("RROGRP", "RROGRP", JdeDataType.String, 8, true, true),
        new JdeField("RRPRP7", "RRPRP7", JdeDataType.String, 12, true, true),
        new JdeField("RRPRP8", "RRPRP8", JdeDataType.String, 12, true, true),
        new JdeField("RRPRP9", "RRPRP9", JdeDataType.String, 12, true, true),
        new JdeField("RRITM", "RRITM", JdeDataType.Numeric, null, true, true),
        new JdeField("RRUOM", "RRUOM", JdeDataType.String, 4, true, true),
        new JdeField("RRMXRR", "RRMXRR", JdeDataType.Numeric),
        new JdeField("RRLETN", "RRLETN", JdeDataType.Numeric),
        new JdeField("RRLETM", "RRLETM", JdeDataType.Numeric),
        new JdeField("RRIQM", "RRIQM", JdeDataType.String, 2),
        new JdeField("RRMBUM", "RRMBUM", JdeDataType.String, 4),
        new JdeField("RRAYN", "RRAYN", JdeDataType.String, 2),
        new JdeField("RREF1", "RREF1", JdeDataType.Numeric, null, true, true),
        new JdeField("RRET1", "RRET1", JdeDataType.Numeric, null, true, true),
        new JdeField("RRUSER", "RRUSER", JdeDataType.String, 20),
        new JdeField("RRPID", "RRPID", JdeDataType.String, 20),
        new JdeField("RRUPMJ", "RRUPMJ", JdeDataType.Numeric),
        new JdeField("RRTDAY", "RRTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F46015_0", "Primary Key on RRMCU, RRSRUL, RRZTYP, RRGZON, RROGRP, RRPRP7, RRPRP8, RRPRP9, RRITM, RRUOM, RREF1, RRET1", new[] { "RRMCU", "RRSRUL", "RRZTYP", "RRGZON", "RROGRP", "RRPRP7", "RRPRP8", "RRPRP9", "RRITM", "RRUOM", "RREF1", "RRET1" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F46015_2", "Index on RRMCU, RRSRUL, RRAYN", new[] { "RRMCU", "RRSRUL", "RRAYN" })
    };
}
