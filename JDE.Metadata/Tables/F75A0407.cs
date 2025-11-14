using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75A0407 - .
/// </summary>
public class F75A0407 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TLCO.
        /// </summary>
        public const string TLCO = "TLCO";

        /// <summary>
        /// TLAUSPTCGI.
        /// </summary>
        public const string TLAUSPTCGI = "TLAUSPTCGI";

        /// <summary>
        /// TLWKSE.
        /// </summary>
        public const string TLWKSE = "TLWKSE";

        /// <summary>
        /// TLAUSPTY.
        /// </summary>
        public const string TLAUSPTY = "TLAUSPTY";

        /// <summary>
        /// TLAUSPTTP.
        /// </summary>
        public const string TLAUSPTTP = "TLAUSPTTP";

        /// <summary>
        /// TLAUSPTPT.
        /// </summary>
        public const string TLAUSPTPT = "TLAUSPTPT";

        /// <summary>
        /// TLAUSPTTL.
        /// </summary>
        public const string TLAUSPTTL = "TLAUSPTTL";

        /// <summary>
        /// TLAUSPTBOC.
        /// </summary>
        public const string TLAUSPTBOC = "TLAUSPTBOC";

        /// <summary>
        /// TLAUSPTTW.
        /// </summary>
        public const string TLAUSPTTW = "TLAUSPTTW";

        /// <summary>
        /// TLAUSPTRTE.
        /// </summary>
        public const string TLAUSPTRTE = "TLAUSPTRTE";

        /// <summary>
        /// TLAUSPTPFI.
        /// </summary>
        public const string TLAUSPTPFI = "TLAUSPTPFI";

        /// <summary>
        /// TLUSER.
        /// </summary>
        public const string TLUSER = "TLUSER";

        /// <summary>
        /// TLPID.
        /// </summary>
        public const string TLPID = "TLPID";

        /// <summary>
        /// TLUPMJ.
        /// </summary>
        public const string TLUPMJ = "TLUPMJ";

        /// <summary>
        /// TLUPMT.
        /// </summary>
        public const string TLUPMT = "TLUPMT";

        /// <summary>
        /// TLJOBN.
        /// </summary>
        public const string TLJOBN = "TLJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F75A0407";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TLCO", "TLCO", JdeDataType.String, 10, true, true),
        new JdeField("TLAUSPTCGI", "TLAUSPTCGI", JdeDataType.String, 16, true, true),
        new JdeField("TLWKSE", "TLWKSE", JdeDataType.String, 6, true, true),
        new JdeField("TLAUSPTY", "TLAUSPTY", JdeDataType.Numeric, null, true, true),
        new JdeField("TLAUSPTTP", "TLAUSPTTP", JdeDataType.String, 4, true, true),
        new JdeField("TLAUSPTPT", "TLAUSPTPT", JdeDataType.Numeric),
        new JdeField("TLAUSPTTL", "TLAUSPTTL", JdeDataType.Numeric),
        new JdeField("TLAUSPTBOC", "TLAUSPTBOC", JdeDataType.String, 2),
        new JdeField("TLAUSPTTW", "TLAUSPTTW", JdeDataType.Numeric),
        new JdeField("TLAUSPTRTE", "TLAUSPTRTE", JdeDataType.Numeric),
        new JdeField("TLAUSPTPFI", "TLAUSPTPFI", JdeDataType.String, 20),
        new JdeField("TLUSER", "TLUSER", JdeDataType.String, 20),
        new JdeField("TLPID", "TLPID", JdeDataType.String, 20),
        new JdeField("TLUPMJ", "TLUPMJ", JdeDataType.Numeric),
        new JdeField("TLUPMT", "TLUPMT", JdeDataType.Numeric),
        new JdeField("TLJOBN", "TLJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75A0407_0", "Primary Key on TLCO, TLAUSPTCGI, TLWKSE, TLAUSPTY, TLAUSPTTP", new[] { "TLCO", "TLAUSPTCGI", "TLWKSE", "TLAUSPTY", "TLAUSPTTP" }, isUnique: true, isPrimaryKey: true)
    };
}
