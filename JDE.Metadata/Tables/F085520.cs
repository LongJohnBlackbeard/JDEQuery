using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F085520 - .
/// </summary>
public class F085520 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PHEVET.
        /// </summary>
        public const string PHEVET = "PHEVET";

        /// <summary>
        /// PHAN8.
        /// </summary>
        public const string PHAN8 = "PHAN8";

        /// <summary>
        /// PHSBGR.
        /// </summary>
        public const string PHSBGR = "PHSBGR";

        /// <summary>
        /// PHDL01.
        /// </summary>
        public const string PHDL01 = "PHDL01";

        /// <summary>
        /// PHPCP#.
        /// </summary>
        public const string PHPCP_ = "PHPCP#";

        /// <summary>
        /// PHPLAN.
        /// </summary>
        public const string PHPLAN = "PHPLAN";

        /// <summary>
        /// PHSEQ#.
        /// </summary>
        public const string PHSEQ_ = "PHSEQ#";

        /// <summary>
        /// PHAOPT.
        /// </summary>
        public const string PHAOPT = "PHAOPT";

        /// <summary>
        /// PHDL02.
        /// </summary>
        public const string PHDL02 = "PHDL02";

        /// <summary>
        /// PHEFT.
        /// </summary>
        public const string PHEFT = "PHEFT";

        /// <summary>
        /// PHEFTE.
        /// </summary>
        public const string PHEFTE = "PHEFTE";

        /// <summary>
        /// PHEECD.
        /// </summary>
        public const string PHEECD = "PHEECD";

        /// <summary>
        /// PHDBEN.
        /// </summary>
        public const string PHDBEN = "PHDBEN";

        /// <summary>
        /// PHPCPVST.
        /// </summary>
        public const string PHPCPVST = "PHPCPVST";

        /// <summary>
        /// PHPCOS.
        /// </summary>
        public const string PHPCOS = "PHPCOS";

        /// <summary>
        /// PHMRTOW.
        /// </summary>
        public const string PHMRTOW = "PHMRTOW";

        /// <summary>
        /// PHEEFC.
        /// </summary>
        public const string PHEEFC = "PHEEFC";

        /// <summary>
        /// PHPCRE.
        /// </summary>
        public const string PHPCRE = "PHPCRE";

        /// <summary>
        /// PHDRTM.
        /// </summary>
        public const string PHDRTM = "PHDRTM";

        /// <summary>
        /// PHBRTM.
        /// </summary>
        public const string PHBRTM = "PHBRTM";

        /// <summary>
        /// PHPID.
        /// </summary>
        public const string PHPID = "PHPID";

        /// <summary>
        /// PHUPMJ.
        /// </summary>
        public const string PHUPMJ = "PHUPMJ";

        /// <summary>
        /// PHUPMT.
        /// </summary>
        public const string PHUPMT = "PHUPMT";

        /// <summary>
        /// PHUSER.
        /// </summary>
        public const string PHUSER = "PHUSER";

        /// <summary>
        /// PHJOBN.
        /// </summary>
        public const string PHJOBN = "PHJOBN";

        /// <summary>
        /// PHESIGN.
        /// </summary>
        public const string PHESIGN = "PHESIGN";

        /// <summary>
        /// PHMUMJ.
        /// </summary>
        public const string PHMUMJ = "PHMUMJ";

        /// <summary>
        /// PHMUMT.
        /// </summary>
        public const string PHMUMT = "PHMUMT";

        /// <summary>
        /// PHUPID.
        /// </summary>
        public const string PHUPID = "PHUPID";
    }

    /// <inheritdoc />
    public override string TableName => "F085520";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PHEVET", "PHEVET", JdeDataType.Numeric, null, true, true),
        new JdeField("PHAN8", "PHAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("PHSBGR", "PHSBGR", JdeDataType.String, 20, true, true),
        new JdeField("PHDL01", "PHDL01", JdeDataType.String, 60),
        new JdeField("PHPCP#", "PHPCP#", JdeDataType.String, 40),
        new JdeField("PHPLAN", "PHPLAN", JdeDataType.String, 16, true, true),
        new JdeField("PHSEQ#", "PHSEQ#", JdeDataType.Numeric, null, true, true),
        new JdeField("PHAOPT", "PHAOPT", JdeDataType.String, 6, true, true),
        new JdeField("PHDL02", "PHDL02", JdeDataType.String, 60),
        new JdeField("PHEFT", "PHEFT", JdeDataType.Numeric),
        new JdeField("PHEFTE", "PHEFTE", JdeDataType.Numeric),
        new JdeField("PHEECD", "PHEECD", JdeDataType.String, 6),
        new JdeField("PHDBEN", "PHDBEN", JdeDataType.String, 2),
        new JdeField("PHPCPVST", "PHPCPVST", JdeDataType.String, 2),
        new JdeField("PHPCOS", "PHPCOS", JdeDataType.Numeric),
        new JdeField("PHMRTOW", "PHMRTOW", JdeDataType.Numeric),
        new JdeField("PHEEFC", "PHEEFC", JdeDataType.Numeric),
        new JdeField("PHPCRE", "PHPCRE", JdeDataType.Numeric),
        new JdeField("PHDRTM", "PHDRTM", JdeDataType.Numeric),
        new JdeField("PHBRTM", "PHBRTM", JdeDataType.Numeric),
        new JdeField("PHPID", "PHPID", JdeDataType.String, 20),
        new JdeField("PHUPMJ", "PHUPMJ", JdeDataType.Numeric),
        new JdeField("PHUPMT", "PHUPMT", JdeDataType.Numeric),
        new JdeField("PHUSER", "PHUSER", JdeDataType.String, 20),
        new JdeField("PHJOBN", "PHJOBN", JdeDataType.String, 20),
        new JdeField("PHESIGN", "PHESIGN", JdeDataType.String, 32, true, true),
        new JdeField("PHMUMJ", "PHMUMJ", JdeDataType.Numeric),
        new JdeField("PHMUMT", "PHMUMT", JdeDataType.Numeric),
        new JdeField("PHUPID", "PHUPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F085520_0", "Primary Key on PHEVET, PHAN8, PHSBGR, PHPLAN, PHSEQ#, PHAOPT, PHESIGN", new[] { "PHEVET", "PHAN8", "PHSBGR", "PHPLAN", "PHSEQ#", "PHAOPT", "PHESIGN" }, isUnique: true, isPrimaryKey: true)
    };
}
