using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F00119 - .
/// </summary>
public class F00119 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IHICUT.
        /// </summary>
        public const string IHICUT = "IHICUT";

        /// <summary>
        /// IHICU.
        /// </summary>
        public const string IHICU = "IHICU";

        /// <summary>
        /// IHBHSEQ.
        /// </summary>
        public const string IHBHSEQ = "IHBHSEQ";

        /// <summary>
        /// IHIST.
        /// </summary>
        public const string IHIST = "IHIST";

        /// <summary>
        /// IHIAPP.
        /// </summary>
        public const string IHIAPP = "IHIAPP";

        /// <summary>
        /// IHAICU.
        /// </summary>
        public const string IHAICU = "IHAICU";

        /// <summary>
        /// IHUSER.
        /// </summary>
        public const string IHUSER = "IHUSER";

        /// <summary>
        /// IHDICJ.
        /// </summary>
        public const string IHDICJ = "IHDICJ";

        /// <summary>
        /// IHNDO.
        /// </summary>
        public const string IHNDO = "IHNDO";

        /// <summary>
        /// IHBAL.
        /// </summary>
        public const string IHBAL = "IHBAL";

        /// <summary>
        /// IHBALJ.
        /// </summary>
        public const string IHBALJ = "IHBALJ";

        /// <summary>
        /// IHAME.
        /// </summary>
        public const string IHAME = "IHAME";

        /// <summary>
        /// IHDOCN.
        /// </summary>
        public const string IHDOCN = "IHDOCN";

        /// <summary>
        /// IHAUSR.
        /// </summary>
        public const string IHAUSR = "IHAUSR";

        /// <summary>
        /// IHPOB.
        /// </summary>
        public const string IHPOB = "IHPOB";

        /// <summary>
        /// IHIBOI.
        /// </summary>
        public const string IHIBOI = "IHIBOI";

        /// <summary>
        /// IHAIPT.
        /// </summary>
        public const string IHAIPT = "IHAIPT";

        /// <summary>
        /// IHOFFP.
        /// </summary>
        public const string IHOFFP = "IHOFFP";

        /// <summary>
        /// IHPID.
        /// </summary>
        public const string IHPID = "IHPID";

        /// <summary>
        /// IHJOBN.
        /// </summary>
        public const string IHJOBN = "IHJOBN";

        /// <summary>
        /// IHUPMJ.
        /// </summary>
        public const string IHUPMJ = "IHUPMJ";

        /// <summary>
        /// IHUPMT.
        /// </summary>
        public const string IHUPMT = "IHUPMT";

        /// <summary>
        /// IHDRSP.
        /// </summary>
        public const string IHDRSP = "IHDRSP";

        /// <summary>
        /// IH52PP.
        /// </summary>
        public const string IH52PP = "IH52PP";

        /// <summary>
        /// IHCBP.
        /// </summary>
        public const string IHCBP = "IHCBP";

        /// <summary>
        /// IHBHDELF.
        /// </summary>
        public const string IHBHDELF = "IHBHDELF";

        /// <summary>
        /// IHBHUID.
        /// </summary>
        public const string IHBHUID = "IHBHUID";

        /// <summary>
        /// IHBHUPMJ.
        /// </summary>
        public const string IHBHUPMJ = "IHBHUPMJ";

        /// <summary>
        /// IHBHUPMT.
        /// </summary>
        public const string IHBHUPMT = "IHBHUPMT";

        /// <summary>
        /// IHBHPID.
        /// </summary>
        public const string IHBHPID = "IHBHPID";

        /// <summary>
        /// IHBHMKEY.
        /// </summary>
        public const string IHBHMKEY = "IHBHMKEY";
    }

    /// <inheritdoc />
    public override string TableName => "F00119";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IHICUT", "IHICUT", JdeDataType.String, 4, true, true),
        new JdeField("IHICU", "IHICU", JdeDataType.Numeric, null, true, true),
        new JdeField("IHBHSEQ", "IHBHSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("IHIST", "IHIST", JdeDataType.String, 2),
        new JdeField("IHIAPP", "IHIAPP", JdeDataType.String, 2),
        new JdeField("IHAICU", "IHAICU", JdeDataType.Numeric),
        new JdeField("IHUSER", "IHUSER", JdeDataType.String, 20),
        new JdeField("IHDICJ", "IHDICJ", JdeDataType.Numeric),
        new JdeField("IHNDO", "IHNDO", JdeDataType.Numeric),
        new JdeField("IHBAL", "IHBAL", JdeDataType.String, 2),
        new JdeField("IHBALJ", "IHBALJ", JdeDataType.String, 2),
        new JdeField("IHAME", "IHAME", JdeDataType.Numeric),
        new JdeField("IHDOCN", "IHDOCN", JdeDataType.Numeric),
        new JdeField("IHAUSR", "IHAUSR", JdeDataType.String, 20),
        new JdeField("IHPOB", "IHPOB", JdeDataType.String, 2),
        new JdeField("IHIBOI", "IHIBOI", JdeDataType.String, 2),
        new JdeField("IHAIPT", "IHAIPT", JdeDataType.Numeric),
        new JdeField("IHOFFP", "IHOFFP", JdeDataType.String, 2),
        new JdeField("IHPID", "IHPID", JdeDataType.String, 20),
        new JdeField("IHJOBN", "IHJOBN", JdeDataType.String, 20),
        new JdeField("IHUPMJ", "IHUPMJ", JdeDataType.Numeric),
        new JdeField("IHUPMT", "IHUPMT", JdeDataType.Numeric),
        new JdeField("IHDRSP", "IHDRSP", JdeDataType.String, 2),
        new JdeField("IH52PP", "IH52PP", JdeDataType.String, 2),
        new JdeField("IHCBP", "IHCBP", JdeDataType.String, 2),
        new JdeField("IHBHDELF", "IHBHDELF", JdeDataType.String, 2),
        new JdeField("IHBHUID", "IHBHUID", JdeDataType.String, 20),
        new JdeField("IHBHUPMJ", "IHBHUPMJ", JdeDataType.Numeric),
        new JdeField("IHBHUPMT", "IHBHUPMT", JdeDataType.Numeric),
        new JdeField("IHBHPID", "IHBHPID", JdeDataType.String, 20),
        new JdeField("IHBHMKEY", "IHBHMKEY", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F00119_0", "Primary Key on IHICUT, IHICU, IHBHSEQ", new[] { "IHICUT", "IHICU", "IHBHSEQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F00119_2", "Index on IHICUT, IHICU, SYS_NC00032$", new[] { "IHICUT", "IHICU", "SYS_NC00032$" })
    };
}
