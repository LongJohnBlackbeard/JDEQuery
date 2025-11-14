using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08463 - .
/// </summary>
public class F08463 : JdeTable
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
        /// VPELEMID.
        /// </summary>
        public const string VPELEMID = "VPELEMID";

        /// <summary>
        /// VPSTPORD.
        /// </summary>
        public const string VPSTPORD = "VPSTPORD";

        /// <summary>
        /// VPINTEX.
        /// </summary>
        public const string VPINTEX = "VPINTEX";

        /// <summary>
        /// VPHIDE.
        /// </summary>
        public const string VPHIDE = "VPHIDE";

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
    public override string TableName => "F08463";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VPPSTCAT", "VPPSTCAT", JdeDataType.String, 20, true, true),
        new JdeField("VPELEMID", "VPELEMID", JdeDataType.String, 20, true, true),
        new JdeField("VPSTPORD", "VPSTPORD", JdeDataType.Numeric),
        new JdeField("VPINTEX", "VPINTEX", JdeDataType.String, 2),
        new JdeField("VPHIDE", "VPHIDE", JdeDataType.String, 2),
        new JdeField("VPPID", "VPPID", JdeDataType.String, 20),
        new JdeField("VPUSER", "VPUSER", JdeDataType.String, 20),
        new JdeField("VPMKEY", "VPMKEY", JdeDataType.String, 30),
        new JdeField("VPUPMJ", "VPUPMJ", JdeDataType.Numeric),
        new JdeField("VPUPMT", "VPUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08463_0", "Primary Key on VPPSTCAT, VPELEMID", new[] { "VPPSTCAT", "VPELEMID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08463_2", "Index on VPPSTCAT, VPSTPORD", new[] { "VPPSTCAT", "VPSTPORD" })
    };
}
