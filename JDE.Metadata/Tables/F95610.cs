using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F95610 - .
/// </summary>
public class F95610 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FUOBNM.
        /// </summary>
        public const string FUOBNM = "FUOBNM";

        /// <summary>
        /// FUVERS.
        /// </summary>
        public const string FUVERS = "FUVERS";

        /// <summary>
        /// FUFRPTMPL.
        /// </summary>
        public const string FUFRPTMPL = "FUFRPTMPL";

        /// <summary>
        /// FUFRPTRNSF.
        /// </summary>
        public const string FUFRPTRNSF = "FUFRPTRNSF";

        /// <summary>
        /// FUGRPROLE.
        /// </summary>
        public const string FUGRPROLE = "FUGRPROLE";

        /// <summary>
        /// FUFRPFUS1.
        /// </summary>
        public const string FUFRPFUS1 = "FUFRPFUS1";

        /// <summary>
        /// FUFRPFUS2.
        /// </summary>
        public const string FUFRPFUS2 = "FUFRPFUS2";

        /// <summary>
        /// FUFRPFUC1.
        /// </summary>
        public const string FUFRPFUC1 = "FUFRPFUC1";

        /// <summary>
        /// FUFRPFUC2.
        /// </summary>
        public const string FUFRPFUC2 = "FUFRPFUC2";

        /// <summary>
        /// FUFRPFUM1.
        /// </summary>
        public const string FUFRPFUM1 = "FUFRPFUM1";

        /// <summary>
        /// FUFRPFUM2.
        /// </summary>
        public const string FUFRPFUM2 = "FUFRPFUM2";

        /// <summary>
        /// FUFRPFUD1.
        /// </summary>
        public const string FUFRPFUD1 = "FUFRPFUD1";

        /// <summary>
        /// FUFRPFUD2.
        /// </summary>
        public const string FUFRPFUD2 = "FUFRPFUD2";

        /// <summary>
        /// FUPID.
        /// </summary>
        public const string FUPID = "FUPID";

        /// <summary>
        /// FUMKEY.
        /// </summary>
        public const string FUMKEY = "FUMKEY";

        /// <summary>
        /// FUUSER.
        /// </summary>
        public const string FUUSER = "FUUSER";

        /// <summary>
        /// FUUPMJ.
        /// </summary>
        public const string FUUPMJ = "FUUPMJ";

        /// <summary>
        /// FUUPMT.
        /// </summary>
        public const string FUUPMT = "FUUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F95610";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FUOBNM", "FUOBNM", JdeDataType.String, 20, true, true),
        new JdeField("FUVERS", "FUVERS", JdeDataType.String, 20, true, true),
        new JdeField("FUFRPTMPL", "FUFRPTMPL", JdeDataType.String, 200, true, true),
        new JdeField("FUFRPTRNSF", "FUFRPTRNSF", JdeDataType.String, 200),
        new JdeField("FUGRPROLE", "FUGRPROLE", JdeDataType.String, 30),
        new JdeField("FUFRPFUS1", "FUFRPFUS1", JdeDataType.String, 60),
        new JdeField("FUFRPFUS2", "FUFRPFUS2", JdeDataType.String, 60),
        new JdeField("FUFRPFUC1", "FUFRPFUC1", JdeDataType.String, 2),
        new JdeField("FUFRPFUC2", "FUFRPFUC2", JdeDataType.String, 2),
        new JdeField("FUFRPFUM1", "FUFRPFUM1", JdeDataType.Numeric),
        new JdeField("FUFRPFUM2", "FUFRPFUM2", JdeDataType.Numeric),
        new JdeField("FUFRPFUD1", "FUFRPFUD1", JdeDataType.Numeric),
        new JdeField("FUFRPFUD2", "FUFRPFUD2", JdeDataType.Numeric),
        new JdeField("FUPID", "FUPID", JdeDataType.String, 20),
        new JdeField("FUMKEY", "FUMKEY", JdeDataType.String, 30),
        new JdeField("FUUSER", "FUUSER", JdeDataType.String, 20),
        new JdeField("FUUPMJ", "FUUPMJ", JdeDataType.Numeric),
        new JdeField("FUUPMT", "FUUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F95610_0", "Primary Key on FUOBNM, FUVERS, FUFRPTMPL", new[] { "FUOBNM", "FUVERS", "FUFRPTMPL" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F95610_2", "Index on FUFRPTMPL", new[] { "FUFRPTMPL" }),
        new JdeIndex("F95610_3", "Index on FUFRPTRNSF", new[] { "FUFRPTRNSF" })
    };
}
