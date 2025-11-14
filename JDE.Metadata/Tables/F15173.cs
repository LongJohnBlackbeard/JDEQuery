using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15173 - .
/// </summary>
public class F15173 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RVLZRVN.
        /// </summary>
        public const string RVLZRVN = "RVLZRVN";

        /// <summary>
        /// RVLZRVDS.
        /// </summary>
        public const string RVLZRVDS = "RVLZRVDS";

        /// <summary>
        /// RVLZRVT.
        /// </summary>
        public const string RVLZRVT = "RVLZRVT";

        /// <summary>
        /// RVLZRVED.
        /// </summary>
        public const string RVLZRVED = "RVLZRVED";

        /// <summary>
        /// RVLZRVEX.
        /// </summary>
        public const string RVLZRVEX = "RVLZRVEX";

        /// <summary>
        /// RVLZRVF.
        /// </summary>
        public const string RVLZRVF = "RVLZRVF";

        /// <summary>
        /// RVCRCD.
        /// </summary>
        public const string RVCRCD = "RVCRCD";

        /// <summary>
        /// RVBCRC.
        /// </summary>
        public const string RVBCRC = "RVBCRC";

        /// <summary>
        /// RVLZFS1.
        /// </summary>
        public const string RVLZFS1 = "RVLZFS1";

        /// <summary>
        /// RVLZFS2.
        /// </summary>
        public const string RVLZFS2 = "RVLZFS2";

        /// <summary>
        /// RVLZFS3.
        /// </summary>
        public const string RVLZFS3 = "RVLZFS3";

        /// <summary>
        /// RVLZFD1.
        /// </summary>
        public const string RVLZFD1 = "RVLZFD1";

        /// <summary>
        /// RVLZFD2.
        /// </summary>
        public const string RVLZFD2 = "RVLZFD2";

        /// <summary>
        /// RVLZFD3.
        /// </summary>
        public const string RVLZFD3 = "RVLZFD3";

        /// <summary>
        /// RVLZFA1.
        /// </summary>
        public const string RVLZFA1 = "RVLZFA1";

        /// <summary>
        /// RVLZFA2.
        /// </summary>
        public const string RVLZFA2 = "RVLZFA2";

        /// <summary>
        /// RVLZFA3.
        /// </summary>
        public const string RVLZFA3 = "RVLZFA3";

        /// <summary>
        /// RVLZFC1.
        /// </summary>
        public const string RVLZFC1 = "RVLZFC1";

        /// <summary>
        /// RVLZFC2.
        /// </summary>
        public const string RVLZFC2 = "RVLZFC2";

        /// <summary>
        /// RVLZFC3.
        /// </summary>
        public const string RVLZFC3 = "RVLZFC3";

        /// <summary>
        /// RVLZFN1.
        /// </summary>
        public const string RVLZFN1 = "RVLZFN1";

        /// <summary>
        /// RVLZFN2.
        /// </summary>
        public const string RVLZFN2 = "RVLZFN2";

        /// <summary>
        /// RVLZFN3.
        /// </summary>
        public const string RVLZFN3 = "RVLZFN3";

        /// <summary>
        /// RVURAB.
        /// </summary>
        public const string RVURAB = "RVURAB";

        /// <summary>
        /// RVURAT.
        /// </summary>
        public const string RVURAT = "RVURAT";

        /// <summary>
        /// RVURCD.
        /// </summary>
        public const string RVURCD = "RVURCD";

        /// <summary>
        /// RVURDT.
        /// </summary>
        public const string RVURDT = "RVURDT";

        /// <summary>
        /// RVURRF.
        /// </summary>
        public const string RVURRF = "RVURRF";

        /// <summary>
        /// RVTORG.
        /// </summary>
        public const string RVTORG = "RVTORG";

        /// <summary>
        /// RVENTJ.
        /// </summary>
        public const string RVENTJ = "RVENTJ";

        /// <summary>
        /// RVUSER.
        /// </summary>
        public const string RVUSER = "RVUSER";

        /// <summary>
        /// RVPID.
        /// </summary>
        public const string RVPID = "RVPID";

        /// <summary>
        /// RVUPMJ.
        /// </summary>
        public const string RVUPMJ = "RVUPMJ";

        /// <summary>
        /// RVUPMT.
        /// </summary>
        public const string RVUPMT = "RVUPMT";

        /// <summary>
        /// RVMKEY.
        /// </summary>
        public const string RVMKEY = "RVMKEY";
    }

    /// <inheritdoc />
    public override string TableName => "F15173";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RVLZRVN", "RVLZRVN", JdeDataType.String, 60, true, true),
        new JdeField("RVLZRVDS", "RVLZRVDS", JdeDataType.String, 160),
        new JdeField("RVLZRVT", "RVLZRVT", JdeDataType.String, 2),
        new JdeField("RVLZRVED", "RVLZRVED", JdeDataType.Numeric, null, true, true),
        new JdeField("RVLZRVEX", "RVLZRVEX", JdeDataType.String, 60),
        new JdeField("RVLZRVF", "RVLZRVF", JdeDataType.Numeric),
        new JdeField("RVCRCD", "RVCRCD", JdeDataType.String, 6),
        new JdeField("RVBCRC", "RVBCRC", JdeDataType.String, 6),
        new JdeField("RVLZFS1", "RVLZFS1", JdeDataType.String, 160),
        new JdeField("RVLZFS2", "RVLZFS2", JdeDataType.String, 160),
        new JdeField("RVLZFS3", "RVLZFS3", JdeDataType.String, 160),
        new JdeField("RVLZFD1", "RVLZFD1", JdeDataType.Numeric),
        new JdeField("RVLZFD2", "RVLZFD2", JdeDataType.Numeric),
        new JdeField("RVLZFD3", "RVLZFD3", JdeDataType.Numeric),
        new JdeField("RVLZFA1", "RVLZFA1", JdeDataType.Numeric),
        new JdeField("RVLZFA2", "RVLZFA2", JdeDataType.Numeric),
        new JdeField("RVLZFA3", "RVLZFA3", JdeDataType.Numeric),
        new JdeField("RVLZFC1", "RVLZFC1", JdeDataType.String, 2),
        new JdeField("RVLZFC2", "RVLZFC2", JdeDataType.String, 2),
        new JdeField("RVLZFC3", "RVLZFC3", JdeDataType.String, 2),
        new JdeField("RVLZFN1", "RVLZFN1", JdeDataType.Numeric),
        new JdeField("RVLZFN2", "RVLZFN2", JdeDataType.Numeric),
        new JdeField("RVLZFN3", "RVLZFN3", JdeDataType.Numeric),
        new JdeField("RVURAB", "RVURAB", JdeDataType.Numeric),
        new JdeField("RVURAT", "RVURAT", JdeDataType.Numeric),
        new JdeField("RVURCD", "RVURCD", JdeDataType.String, 4),
        new JdeField("RVURDT", "RVURDT", JdeDataType.Numeric),
        new JdeField("RVURRF", "RVURRF", JdeDataType.String, 30),
        new JdeField("RVTORG", "RVTORG", JdeDataType.String, 20),
        new JdeField("RVENTJ", "RVENTJ", JdeDataType.Numeric),
        new JdeField("RVUSER", "RVUSER", JdeDataType.String, 20),
        new JdeField("RVPID", "RVPID", JdeDataType.String, 20),
        new JdeField("RVUPMJ", "RVUPMJ", JdeDataType.Numeric),
        new JdeField("RVUPMT", "RVUPMT", JdeDataType.Numeric),
        new JdeField("RVMKEY", "RVMKEY", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15173_0", "Primary Key on RVLZRVN, RVLZRVED", new[] { "RVLZRVN", "RVLZRVED" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F15173_2", "Index on RVLZRVN", new[] { "RVLZRVN" })
    };
}
