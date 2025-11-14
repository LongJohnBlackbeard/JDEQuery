using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43Q212 - .
/// </summary>
public class F43Q212 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PCEVNU.
        /// </summary>
        public const string PCEVNU = "PCEVNU";

        /// <summary>
        /// PCDCTO.
        /// </summary>
        public const string PCDCTO = "PCDCTO";

        /// <summary>
        /// PCKCOO.
        /// </summary>
        public const string PCKCOO = "PCKCOO";

        /// <summary>
        /// PCEVLN.
        /// </summary>
        public const string PCEVLN = "PCEVLN";

        /// <summary>
        /// PCBIDQN.
        /// </summary>
        public const string PCBIDQN = "PCBIDQN";

        /// <summary>
        /// PCPCPTN.
        /// </summary>
        public const string PCPCPTN = "PCPCPTN";

        /// <summary>
        /// PCPCPD.
        /// </summary>
        public const string PCPCPD = "PCPCPD";

        /// <summary>
        /// PCURCD.
        /// </summary>
        public const string PCURCD = "PCURCD";

        /// <summary>
        /// PCURDT.
        /// </summary>
        public const string PCURDT = "PCURDT";

        /// <summary>
        /// PCURAT.
        /// </summary>
        public const string PCURAT = "PCURAT";

        /// <summary>
        /// PCURAB.
        /// </summary>
        public const string PCURAB = "PCURAB";

        /// <summary>
        /// PCURRF.
        /// </summary>
        public const string PCURRF = "PCURRF";

        /// <summary>
        /// PCTORG.
        /// </summary>
        public const string PCTORG = "PCTORG";

        /// <summary>
        /// PCUSER.
        /// </summary>
        public const string PCUSER = "PCUSER";

        /// <summary>
        /// PCPID.
        /// </summary>
        public const string PCPID = "PCPID";

        /// <summary>
        /// PCJOBN.
        /// </summary>
        public const string PCJOBN = "PCJOBN";

        /// <summary>
        /// PCUPMJ.
        /// </summary>
        public const string PCUPMJ = "PCUPMJ";

        /// <summary>
        /// PCTDAY.
        /// </summary>
        public const string PCTDAY = "PCTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F43Q212";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PCEVNU", "PCEVNU", JdeDataType.Numeric, null, true, true),
        new JdeField("PCDCTO", "PCDCTO", JdeDataType.String, 4, true, true),
        new JdeField("PCKCOO", "PCKCOO", JdeDataType.String, 10, true, true),
        new JdeField("PCEVLN", "PCEVLN", JdeDataType.Numeric, null, true, true),
        new JdeField("PCBIDQN", "PCBIDQN", JdeDataType.Numeric, null, true, true),
        new JdeField("PCPCPTN", "PCPCPTN", JdeDataType.Numeric, null, true, true),
        new JdeField("PCPCPD", "PCPCPD", JdeDataType.String, 80),
        new JdeField("PCURCD", "PCURCD", JdeDataType.String, 4),
        new JdeField("PCURDT", "PCURDT", JdeDataType.Numeric),
        new JdeField("PCURAT", "PCURAT", JdeDataType.Numeric),
        new JdeField("PCURAB", "PCURAB", JdeDataType.Numeric),
        new JdeField("PCURRF", "PCURRF", JdeDataType.String, 30),
        new JdeField("PCTORG", "PCTORG", JdeDataType.String, 20),
        new JdeField("PCUSER", "PCUSER", JdeDataType.String, 20),
        new JdeField("PCPID", "PCPID", JdeDataType.String, 20),
        new JdeField("PCJOBN", "PCJOBN", JdeDataType.String, 20),
        new JdeField("PCUPMJ", "PCUPMJ", JdeDataType.Numeric),
        new JdeField("PCTDAY", "PCTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43Q212_0", "Primary Key on PCEVNU, PCDCTO, PCKCOO, PCEVLN, PCBIDQN, PCPCPTN", new[] { "PCEVNU", "PCDCTO", "PCKCOO", "PCEVLN", "PCBIDQN", "PCPCPTN" }, isUnique: true, isPrimaryKey: true)
    };
}
