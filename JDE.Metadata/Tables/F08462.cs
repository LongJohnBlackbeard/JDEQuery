using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08462 - .
/// </summary>
public class F08462 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VPPSTCAT.
        /// </summary>
        public const string VPPSTCAT = "VPPSTCAT";

        /// <summary>
        /// VPAPPLACT.
        /// </summary>
        public const string VPAPPLACT = "VPAPPLACT";

        /// <summary>
        /// VPINEXB.
        /// </summary>
        public const string VPINEXB = "VPINEXB";

        /// <summary>
        /// VPPID.
        /// </summary>
        public const string VPPID = "VPPID";

        /// <summary>
        /// VPUSER.
        /// </summary>
        public const string VPUSER = "VPUSER";

        /// <summary>
        /// VPMKEY.
        /// </summary>
        public const string VPMKEY = "VPMKEY";

        /// <summary>
        /// VPUPMJ.
        /// </summary>
        public const string VPUPMJ = "VPUPMJ";

        /// <summary>
        /// VPUPMT.
        /// </summary>
        public const string VPUPMT = "VPUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F08462";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VPPSTCAT", "VPPSTCAT", JdeDataType.String, 20, true, true),
        new JdeField("VPAPPLACT", "VPAPPLACT", JdeDataType.String, 20, true, true),
        new JdeField("VPINEXB", "VPINEXB", JdeDataType.String, 2),
        new JdeField("VPPID", "VPPID", JdeDataType.String, 20),
        new JdeField("VPUSER", "VPUSER", JdeDataType.String, 20),
        new JdeField("VPMKEY", "VPMKEY", JdeDataType.String, 30),
        new JdeField("VPUPMJ", "VPUPMJ", JdeDataType.Numeric),
        new JdeField("VPUPMT", "VPUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08462_0", "Primary Key on VPPSTCAT, VPAPPLACT", new[] { "VPPSTCAT", "VPAPPLACT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08462_2", "Index on VPPSTCAT, VPAPPLACT, VPINEXB", new[] { "VPPSTCAT", "VPAPPLACT", "VPINEXB" })
    };
}
