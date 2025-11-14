using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F46093T - .
/// </summary>
public class F46093T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JCMCU.
        /// </summary>
        public const string JCMCU = "JCMCU";

        /// <summary>
        /// JCPRP7.
        /// </summary>
        public const string JCPRP7 = "JCPRP7";

        /// <summary>
        /// JCPRP8.
        /// </summary>
        public const string JCPRP8 = "JCPRP8";

        /// <summary>
        /// JCPRP9.
        /// </summary>
        public const string JCPRP9 = "JCPRP9";

        /// <summary>
        /// JCOGRP.
        /// </summary>
        public const string JCOGRP = "JCOGRP";

        /// <summary>
        /// JCPRIPICK.
        /// </summary>
        public const string JCPRIPICK = "JCPRIPICK";

        /// <summary>
        /// JCPRIREPL.
        /// </summary>
        public const string JCPRIREPL = "JCPRIREPL";

        /// <summary>
        /// JCURAT.
        /// </summary>
        public const string JCURAT = "JCURAT";

        /// <summary>
        /// JCURCD.
        /// </summary>
        public const string JCURCD = "JCURCD";

        /// <summary>
        /// JCURDT.
        /// </summary>
        public const string JCURDT = "JCURDT";

        /// <summary>
        /// JCURAB.
        /// </summary>
        public const string JCURAB = "JCURAB";

        /// <summary>
        /// JCURRF.
        /// </summary>
        public const string JCURRF = "JCURRF";

        /// <summary>
        /// JCUSER.
        /// </summary>
        public const string JCUSER = "JCUSER";

        /// <summary>
        /// JCPID.
        /// </summary>
        public const string JCPID = "JCPID";

        /// <summary>
        /// JCJOBN.
        /// </summary>
        public const string JCJOBN = "JCJOBN";

        /// <summary>
        /// JCUPMJ.
        /// </summary>
        public const string JCUPMJ = "JCUPMJ";

        /// <summary>
        /// JCTDAY.
        /// </summary>
        public const string JCTDAY = "JCTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F46093T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JCMCU", "JCMCU", JdeDataType.String, 24, true, true),
        new JdeField("JCPRP7", "JCPRP7", JdeDataType.String, 12, true, true),
        new JdeField("JCPRP8", "JCPRP8", JdeDataType.String, 12, true, true),
        new JdeField("JCPRP9", "JCPRP9", JdeDataType.String, 12, true, true),
        new JdeField("JCOGRP", "JCOGRP", JdeDataType.String, 8, true, true),
        new JdeField("JCPRIPICK", "JCPRIPICK", JdeDataType.String, 2),
        new JdeField("JCPRIREPL", "JCPRIREPL", JdeDataType.String, 2),
        new JdeField("JCURAT", "JCURAT", JdeDataType.Numeric),
        new JdeField("JCURCD", "JCURCD", JdeDataType.String, 4),
        new JdeField("JCURDT", "JCURDT", JdeDataType.Numeric),
        new JdeField("JCURAB", "JCURAB", JdeDataType.Numeric),
        new JdeField("JCURRF", "JCURRF", JdeDataType.String, 30),
        new JdeField("JCUSER", "JCUSER", JdeDataType.String, 20),
        new JdeField("JCPID", "JCPID", JdeDataType.String, 20),
        new JdeField("JCJOBN", "JCJOBN", JdeDataType.String, 20),
        new JdeField("JCUPMJ", "JCUPMJ", JdeDataType.Numeric),
        new JdeField("JCTDAY", "JCTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F46093T_0", "Primary Key on JCMCU, JCPRP7, JCPRP8, JCPRP9, JCOGRP", new[] { "JCMCU", "JCPRP7", "JCPRP8", "JCPRP9", "JCOGRP" }, isUnique: true, isPrimaryKey: true)
    };
}
