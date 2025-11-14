using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F48221 - .
/// </summary>
public class F48221 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WHICU.
        /// </summary>
        public const string WHICU = "WHICU";

        /// <summary>
        /// WHAN8O.
        /// </summary>
        public const string WHAN8O = "WHAN8O";

        /// <summary>
        /// WHKCOI.
        /// </summary>
        public const string WHKCOI = "WHKCOI";

        /// <summary>
        /// WHDOCZ.
        /// </summary>
        public const string WHDOCZ = "WHDOCZ";

        /// <summary>
        /// WHDCTI.
        /// </summary>
        public const string WHDCTI = "WHDCTI";

        /// <summary>
        /// WHSFX.
        /// </summary>
        public const string WHSFX = "WHSFX";

        /// <summary>
        /// WHKCO.
        /// </summary>
        public const string WHKCO = "WHKCO";

        /// <summary>
        /// WHDOC.
        /// </summary>
        public const string WHDOC = "WHDOC";

        /// <summary>
        /// WHDCT.
        /// </summary>
        public const string WHDCT = "WHDCT";

        /// <summary>
        /// WHSFXM.
        /// </summary>
        public const string WHSFXM = "WHSFXM";

        /// <summary>
        /// WHRTNP.
        /// </summary>
        public const string WHRTNP = "WHRTNP";

        /// <summary>
        /// WHFTNP.
        /// </summary>
        public const string WHFTNP = "WHFTNP";

        /// <summary>
        /// WHDDTR.
        /// </summary>
        public const string WHDDTR = "WHDDTR";

        /// <summary>
        /// WHFDTR.
        /// </summary>
        public const string WHFDTR = "WHFDTR";

        /// <summary>
        /// WHPID.
        /// </summary>
        public const string WHPID = "WHPID";

        /// <summary>
        /// WHJOBN.
        /// </summary>
        public const string WHJOBN = "WHJOBN";

        /// <summary>
        /// WHUSER.
        /// </summary>
        public const string WHUSER = "WHUSER";

        /// <summary>
        /// WHMUPM.
        /// </summary>
        public const string WHMUPM = "WHMUPM";

        /// <summary>
        /// WHUPMT.
        /// </summary>
        public const string WHUPMT = "WHUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F48221";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WHICU", "WHICU", JdeDataType.Numeric, null, true, true),
        new JdeField("WHAN8O", "WHAN8O", JdeDataType.Numeric, null, true, true),
        new JdeField("WHKCOI", "WHKCOI", JdeDataType.String, 10, true, true),
        new JdeField("WHDOCZ", "WHDOCZ", JdeDataType.Numeric, null, true, true),
        new JdeField("WHDCTI", "WHDCTI", JdeDataType.String, 4, true, true),
        new JdeField("WHSFX", "WHSFX", JdeDataType.String, 6, true, true),
        new JdeField("WHKCO", "WHKCO", JdeDataType.String, 10),
        new JdeField("WHDOC", "WHDOC", JdeDataType.Numeric),
        new JdeField("WHDCT", "WHDCT", JdeDataType.String, 4),
        new JdeField("WHSFXM", "WHSFXM", JdeDataType.String, 6),
        new JdeField("WHRTNP", "WHRTNP", JdeDataType.Numeric),
        new JdeField("WHFTNP", "WHFTNP", JdeDataType.Numeric),
        new JdeField("WHDDTR", "WHDDTR", JdeDataType.Numeric),
        new JdeField("WHFDTR", "WHFDTR", JdeDataType.Numeric),
        new JdeField("WHPID", "WHPID", JdeDataType.String, 20),
        new JdeField("WHJOBN", "WHJOBN", JdeDataType.String, 20),
        new JdeField("WHUSER", "WHUSER", JdeDataType.String, 20),
        new JdeField("WHMUPM", "WHMUPM", JdeDataType.Numeric),
        new JdeField("WHUPMT", "WHUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F48221_0", "Primary Key on WHICU, WHAN8O, WHKCOI, WHDOCZ, WHDCTI, WHSFX", new[] { "WHICU", "WHAN8O", "WHKCOI", "WHDOCZ", "WHDCTI", "WHSFX" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F48221_2", "Index on WHDOC, WHDCT, WHKCO, WHSFXM", new[] { "WHDOC", "WHDCT", "WHKCO", "WHSFXM" })
    };
}
