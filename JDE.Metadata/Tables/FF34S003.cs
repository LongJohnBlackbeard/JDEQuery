using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF34S003 - .
/// </summary>
public class FF34S003 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PPFSCID.
        /// </summary>
        public const string PPFSCID = "PPFSCID";

        /// <summary>
        /// PPDFLNID.
        /// </summary>
        public const string PPDFLNID = "PPDFLNID";

        /// <summary>
        /// PPDFSPT.
        /// </summary>
        public const string PPDFSPT = "PPDFSPT";

        /// <summary>
        /// PPDFMCU.
        /// </summary>
        public const string PPDFMCU = "PPDFMCU";

        /// <summary>
        /// PPWDCT.
        /// </summary>
        public const string PPWDCT = "PPWDCT";

        /// <summary>
        /// PPWDCK.
        /// </summary>
        public const string PPWDCK = "PPWDCK";

        /// <summary>
        /// PPDFSEQ.
        /// </summary>
        public const string PPDFSEQ = "PPDFSEQ";

        /// <summary>
        /// PPDFSEQI.
        /// </summary>
        public const string PPDFSEQI = "PPDFSEQI";

        /// <summary>
        /// PPURCD.
        /// </summary>
        public const string PPURCD = "PPURCD";

        /// <summary>
        /// PPUURDT.
        /// </summary>
        public const string PPUURDT = "PPUURDT";

        /// <summary>
        /// PPURAT.
        /// </summary>
        public const string PPURAT = "PPURAT";

        /// <summary>
        /// PPURAB.
        /// </summary>
        public const string PPURAB = "PPURAB";

        /// <summary>
        /// PPURRF.
        /// </summary>
        public const string PPURRF = "PPURRF";

        /// <summary>
        /// PPPID.
        /// </summary>
        public const string PPPID = "PPPID";

        /// <summary>
        /// PPUUPMJ.
        /// </summary>
        public const string PPUUPMJ = "PPUUPMJ";

        /// <summary>
        /// PPMKEY.
        /// </summary>
        public const string PPMKEY = "PPMKEY";

        /// <summary>
        /// PPUSER.
        /// </summary>
        public const string PPUSER = "PPUSER";
    }

    /// <inheritdoc />
    public override string TableName => "FF34S003";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PPFSCID", "PPFSCID", JdeDataType.Numeric, null, true, true),
        new JdeField("PPDFLNID", "PPDFLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("PPDFSPT", "PPDFSPT", JdeDataType.Numeric),
        new JdeField("PPDFMCU", "PPDFMCU", JdeDataType.String, 24),
        new JdeField("PPWDCT", "PPWDCT", JdeDataType.String, 20),
        new JdeField("PPWDCK", "PPWDCK", JdeDataType.String, 20),
        new JdeField("PPDFSEQ", "PPDFSEQ", JdeDataType.Numeric),
        new JdeField("PPDFSEQI", "PPDFSEQI", JdeDataType.Numeric),
        new JdeField("PPURCD", "PPURCD", JdeDataType.String, 4),
        new JdeField("PPUURDT", "PPUURDT", JdeDataType.Date),
        new JdeField("PPURAT", "PPURAT", JdeDataType.Numeric),
        new JdeField("PPURAB", "PPURAB", JdeDataType.Numeric),
        new JdeField("PPURRF", "PPURRF", JdeDataType.String, 30),
        new JdeField("PPPID", "PPPID", JdeDataType.String, 20),
        new JdeField("PPUUPMJ", "PPUUPMJ", JdeDataType.Date),
        new JdeField("PPMKEY", "PPMKEY", JdeDataType.String, 30),
        new JdeField("PPUSER", "PPUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF34S003_0", "Primary Key on PPFSCID, PPDFLNID", new[] { "PPFSCID", "PPDFLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
