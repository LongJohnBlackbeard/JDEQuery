using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F52G200 - .
/// </summary>
public class F52G200 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LSDOCO.
        /// </summary>
        public const string LSDOCO = "LSDOCO";

        /// <summary>
        /// LSDCTO.
        /// </summary>
        public const string LSDCTO = "LSDCTO";

        /// <summary>
        /// LSKCOO.
        /// </summary>
        public const string LSKCOO = "LSKCOO";

        /// <summary>
        /// LSPRTPG.
        /// </summary>
        public const string LSPRTPG = "LSPRTPG";

        /// <summary>
        /// LSTIAMD.
        /// </summary>
        public const string LSTIAMD = "LSTIAMD";

        /// <summary>
        /// LSTIEXD.
        /// </summary>
        public const string LSTIEXD = "LSTIEXD";

        /// <summary>
        /// LSTRAMD.
        /// </summary>
        public const string LSTRAMD = "LSTRAMD";

        /// <summary>
        /// LSTREXD.
        /// </summary>
        public const string LSTREXD = "LSTREXD";

        /// <summary>
        /// LSTTAMD.
        /// </summary>
        public const string LSTTAMD = "LSTTAMD";

        /// <summary>
        /// LSTTEXD.
        /// </summary>
        public const string LSTTEXD = "LSTTEXD";

        /// <summary>
        /// LSCRCD.
        /// </summary>
        public const string LSCRCD = "LSCRCD";

        /// <summary>
        /// LSPID.
        /// </summary>
        public const string LSPID = "LSPID";

        /// <summary>
        /// LSMKEY.
        /// </summary>
        public const string LSMKEY = "LSMKEY";

        /// <summary>
        /// LSUSER.
        /// </summary>
        public const string LSUSER = "LSUSER";

        /// <summary>
        /// LSMUPM.
        /// </summary>
        public const string LSMUPM = "LSMUPM";

        /// <summary>
        /// LSUPMT.
        /// </summary>
        public const string LSUPMT = "LSUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F52G200";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LSDOCO", "LSDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("LSDCTO", "LSDCTO", JdeDataType.String, 4, true, true),
        new JdeField("LSKCOO", "LSKCOO", JdeDataType.String, 10, true, true),
        new JdeField("LSPRTPG", "LSPRTPG", JdeDataType.String, 2, true, true),
        new JdeField("LSTIAMD", "LSTIAMD", JdeDataType.Numeric),
        new JdeField("LSTIEXD", "LSTIEXD", JdeDataType.Numeric),
        new JdeField("LSTRAMD", "LSTRAMD", JdeDataType.Numeric),
        new JdeField("LSTREXD", "LSTREXD", JdeDataType.Numeric),
        new JdeField("LSTTAMD", "LSTTAMD", JdeDataType.Numeric),
        new JdeField("LSTTEXD", "LSTTEXD", JdeDataType.Numeric),
        new JdeField("LSCRCD", "LSCRCD", JdeDataType.String, 6),
        new JdeField("LSPID", "LSPID", JdeDataType.String, 20),
        new JdeField("LSMKEY", "LSMKEY", JdeDataType.String, 30),
        new JdeField("LSUSER", "LSUSER", JdeDataType.String, 20),
        new JdeField("LSMUPM", "LSMUPM", JdeDataType.Numeric),
        new JdeField("LSUPMT", "LSUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F52G200_0", "Primary Key on LSDOCO, LSDCTO, LSKCOO, LSPRTPG", new[] { "LSDOCO", "LSDCTO", "LSKCOO", "LSPRTPG" }, isUnique: true, isPrimaryKey: true)
    };
}
