using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F47103 - .
/// </summary>
public class F47103 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SZEDTY.
        /// </summary>
        public const string SZEDTY = "SZEDTY";

        /// <summary>
        /// SZEDSQ.
        /// </summary>
        public const string SZEDSQ = "SZEDSQ";

        /// <summary>
        /// SZEKCO.
        /// </summary>
        public const string SZEKCO = "SZEKCO";

        /// <summary>
        /// SZEDOC.
        /// </summary>
        public const string SZEDOC = "SZEDOC";

        /// <summary>
        /// SZEDCT.
        /// </summary>
        public const string SZEDCT = "SZEDCT";

        /// <summary>
        /// SZEDLN.
        /// </summary>
        public const string SZEDLN = "SZEDLN";

        /// <summary>
        /// SZKCOO.
        /// </summary>
        public const string SZKCOO = "SZKCOO";

        /// <summary>
        /// SZDOCO.
        /// </summary>
        public const string SZDOCO = "SZDOCO";

        /// <summary>
        /// SZDCTO.
        /// </summary>
        public const string SZDCTO = "SZDCTO";

        /// <summary>
        /// SZLNID.
        /// </summary>
        public const string SZLNID = "SZLNID";

        /// <summary>
        /// SZAN8.
        /// </summary>
        public const string SZAN8 = "SZAN8";

        /// <summary>
        /// SZUORG.
        /// </summary>
        public const string SZUORG = "SZUORG";

        /// <summary>
        /// SZPRRC.
        /// </summary>
        public const string SZPRRC = "SZPRRC";

        /// <summary>
        /// SZPDDJ.
        /// </summary>
        public const string SZPDDJ = "SZPDDJ";

        /// <summary>
        /// SZCNDJ.
        /// </summary>
        public const string SZCNDJ = "SZCNDJ";

        /// <summary>
        /// SZCRCD.
        /// </summary>
        public const string SZCRCD = "SZCRCD";

        /// <summary>
        /// SZTORG.
        /// </summary>
        public const string SZTORG = "SZTORG";

        /// <summary>
        /// SZUSER.
        /// </summary>
        public const string SZUSER = "SZUSER";

        /// <summary>
        /// SZPID.
        /// </summary>
        public const string SZPID = "SZPID";

        /// <summary>
        /// SZJOBN.
        /// </summary>
        public const string SZJOBN = "SZJOBN";

        /// <summary>
        /// SZUPMJ.
        /// </summary>
        public const string SZUPMJ = "SZUPMJ";

        /// <summary>
        /// SZTDAY.
        /// </summary>
        public const string SZTDAY = "SZTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F47103";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SZEDTY", "SZEDTY", JdeDataType.String, 2),
        new JdeField("SZEDSQ", "SZEDSQ", JdeDataType.Numeric),
        new JdeField("SZEKCO", "SZEKCO", JdeDataType.String, 10, true, true),
        new JdeField("SZEDOC", "SZEDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("SZEDCT", "SZEDCT", JdeDataType.String, 4, true, true),
        new JdeField("SZEDLN", "SZEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("SZKCOO", "SZKCOO", JdeDataType.String, 10),
        new JdeField("SZDOCO", "SZDOCO", JdeDataType.Numeric),
        new JdeField("SZDCTO", "SZDCTO", JdeDataType.String, 4),
        new JdeField("SZLNID", "SZLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("SZAN8", "SZAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("SZUORG", "SZUORG", JdeDataType.Numeric),
        new JdeField("SZPRRC", "SZPRRC", JdeDataType.Numeric),
        new JdeField("SZPDDJ", "SZPDDJ", JdeDataType.Numeric),
        new JdeField("SZCNDJ", "SZCNDJ", JdeDataType.Numeric),
        new JdeField("SZCRCD", "SZCRCD", JdeDataType.String, 6),
        new JdeField("SZTORG", "SZTORG", JdeDataType.String, 20),
        new JdeField("SZUSER", "SZUSER", JdeDataType.String, 20),
        new JdeField("SZPID", "SZPID", JdeDataType.String, 20),
        new JdeField("SZJOBN", "SZJOBN", JdeDataType.String, 20),
        new JdeField("SZUPMJ", "SZUPMJ", JdeDataType.Numeric),
        new JdeField("SZTDAY", "SZTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F47103_0", "Primary Key on SZEDOC, SZEDCT, SZEKCO, SZEDLN, SZLNID, SZAN8", new[] { "SZEDOC", "SZEDCT", "SZEKCO", "SZEDLN", "SZLNID", "SZAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
