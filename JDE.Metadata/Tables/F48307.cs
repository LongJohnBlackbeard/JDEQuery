using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F48307 - .
/// </summary>
public class F48307 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RHRCALT.
        /// </summary>
        public const string RHRCALT = "RHRCALT";

        /// <summary>
        /// RHMMCU.
        /// </summary>
        public const string RHMMCU = "RHMMCU";

        /// <summary>
        /// RHWDCT.
        /// </summary>
        public const string RHWDCT = "RHWDCT";

        /// <summary>
        /// RHWDCK.
        /// </summary>
        public const string RHWDCK = "RHWDCK";

        /// <summary>
        /// RHSHFT.
        /// </summary>
        public const string RHSHFT = "RHSHFT";

        /// <summary>
        /// RHRRTY.
        /// </summary>
        public const string RHRRTY = "RHRRTY";

        /// <summary>
        /// RHRSCN.
        /// </summary>
        public const string RHRSCN = "RHRSCN";

        /// <summary>
        /// RHSDOW.
        /// </summary>
        public const string RHSDOW = "RHSDOW";

        /// <summary>
        /// RHDTFR.
        /// </summary>
        public const string RHDTFR = "RHDTFR";

        /// <summary>
        /// RHDTTO.
        /// </summary>
        public const string RHDTTO = "RHDTTO";

        /// <summary>
        /// RHWDAYST.
        /// </summary>
        public const string RHWDAYST = "RHWDAYST";

        /// <summary>
        /// RHWDAYET.
        /// </summary>
        public const string RHWDAYET = "RHWDAYET";

        /// <summary>
        /// RHWDAYST2.
        /// </summary>
        public const string RHWDAYST2 = "RHWDAYST2";

        /// <summary>
        /// RHWDAYET2.
        /// </summary>
        public const string RHWDAYET2 = "RHWDAYET2";

        /// <summary>
        /// RHWDAYST3.
        /// </summary>
        public const string RHWDAYST3 = "RHWDAYST3";

        /// <summary>
        /// RHWDAYET3.
        /// </summary>
        public const string RHWDAYET3 = "RHWDAYET3";

        /// <summary>
        /// RHDAVL.
        /// </summary>
        public const string RHDAVL = "RHDAVL";

        /// <summary>
        /// RHUSER.
        /// </summary>
        public const string RHUSER = "RHUSER";

        /// <summary>
        /// RHPID.
        /// </summary>
        public const string RHPID = "RHPID";

        /// <summary>
        /// RHJOBN.
        /// </summary>
        public const string RHJOBN = "RHJOBN";

        /// <summary>
        /// RHUPMJ.
        /// </summary>
        public const string RHUPMJ = "RHUPMJ";

        /// <summary>
        /// RHUPMT.
        /// </summary>
        public const string RHUPMT = "RHUPMT";

        /// <summary>
        /// RHRHOVR.
        /// </summary>
        public const string RHRHOVR = "RHRHOVR";

        /// <summary>
        /// RHURAB.
        /// </summary>
        public const string RHURAB = "RHURAB";

        /// <summary>
        /// RHURAT.
        /// </summary>
        public const string RHURAT = "RHURAT";

        /// <summary>
        /// RHURCD.
        /// </summary>
        public const string RHURCD = "RHURCD";

        /// <summary>
        /// RHURDT.
        /// </summary>
        public const string RHURDT = "RHURDT";

        /// <summary>
        /// RHURRF.
        /// </summary>
        public const string RHURRF = "RHURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F48307";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RHRCALT", "RHRCALT", JdeDataType.String, 2, true, true),
        new JdeField("RHMMCU", "RHMMCU", JdeDataType.String, 24, true, true),
        new JdeField("RHWDCT", "RHWDCT", JdeDataType.String, 20, true, true),
        new JdeField("RHWDCK", "RHWDCK", JdeDataType.String, 20, true, true),
        new JdeField("RHSHFT", "RHSHFT", JdeDataType.String, 2, true, true),
        new JdeField("RHRRTY", "RHRRTY", JdeDataType.String, 4, true, true),
        new JdeField("RHRSCN", "RHRSCN", JdeDataType.Numeric, null, true, true),
        new JdeField("RHSDOW", "RHSDOW", JdeDataType.Numeric, null, true, true),
        new JdeField("RHDTFR", "RHDTFR", JdeDataType.Numeric, null, true, true),
        new JdeField("RHDTTO", "RHDTTO", JdeDataType.Numeric),
        new JdeField("RHWDAYST", "RHWDAYST", JdeDataType.Numeric),
        new JdeField("RHWDAYET", "RHWDAYET", JdeDataType.Numeric),
        new JdeField("RHWDAYST2", "RHWDAYST2", JdeDataType.Numeric),
        new JdeField("RHWDAYET2", "RHWDAYET2", JdeDataType.Numeric),
        new JdeField("RHWDAYST3", "RHWDAYST3", JdeDataType.Numeric),
        new JdeField("RHWDAYET3", "RHWDAYET3", JdeDataType.Numeric),
        new JdeField("RHDAVL", "RHDAVL", JdeDataType.Numeric),
        new JdeField("RHUSER", "RHUSER", JdeDataType.String, 20),
        new JdeField("RHPID", "RHPID", JdeDataType.String, 20),
        new JdeField("RHJOBN", "RHJOBN", JdeDataType.String, 20),
        new JdeField("RHUPMJ", "RHUPMJ", JdeDataType.Numeric),
        new JdeField("RHUPMT", "RHUPMT", JdeDataType.Numeric),
        new JdeField("RHRHOVR", "RHRHOVR", JdeDataType.String, 6),
        new JdeField("RHURAB", "RHURAB", JdeDataType.Numeric),
        new JdeField("RHURAT", "RHURAT", JdeDataType.Numeric),
        new JdeField("RHURCD", "RHURCD", JdeDataType.String, 4),
        new JdeField("RHURDT", "RHURDT", JdeDataType.Numeric),
        new JdeField("RHURRF", "RHURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F48307_0", "Primary Key on RHRCALT, RHWDCT, RHMMCU, RHWDCK, RHSHFT, RHRRTY, RHRSCN, RHSDOW, RHDTFR", new[] { "RHRCALT", "RHWDCT", "RHMMCU", "RHWDCK", "RHSHFT", "RHRRTY", "RHRSCN", "RHSDOW", "RHDTFR" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F48307_2", "Index on RHRCALT, RHRRTY, RHRSCN, RHDTFR, RHSHFT", new[] { "RHRCALT", "RHRRTY", "RHRSCN", "RHDTFR", "RHSHFT" })
    };
}
