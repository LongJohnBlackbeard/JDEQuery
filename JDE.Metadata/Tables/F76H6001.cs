using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76H6001 - .
/// </summary>
public class F76H6001 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PHH76LECO.
        /// </summary>
        public const string PHH76LECO = "PHH76LECO";

        /// <summary>
        /// PHCFY.
        /// </summary>
        public const string PHCFY = "PHCFY";

        /// <summary>
        /// PHFFP.
        /// </summary>
        public const string PHFFP = "PHFFP";

        /// <summary>
        /// PHFTP.
        /// </summary>
        public const string PHFTP = "PHFTP";

        /// <summary>
        /// PHDL01.
        /// </summary>
        public const string PHDL01 = "PHDL01";

        /// <summary>
        /// PHABT1.
        /// </summary>
        public const string PHABT1 = "PHABT1";

        /// <summary>
        /// PHABT2.
        /// </summary>
        public const string PHABT2 = "PHABT2";

        /// <summary>
        /// PHABT3.
        /// </summary>
        public const string PHABT3 = "PHABT3";

        /// <summary>
        /// PHABT4.
        /// </summary>
        public const string PHABT4 = "PHABT4";

        /// <summary>
        /// PHLEDG.
        /// </summary>
        public const string PHLEDG = "PHLEDG";

        /// <summary>
        /// PHLT.
        /// </summary>
        public const string PHLT = "PHLT";

        /// <summary>
        /// PHH76ICPS.
        /// </summary>
        public const string PHH76ICPS = "PHH76ICPS";

        /// <summary>
        /// PHH76WODS.
        /// </summary>
        public const string PHH76WODS = "PHH76WODS";

        /// <summary>
        /// PHTBM.
        /// </summary>
        public const string PHTBM = "PHTBM";

        /// <summary>
        /// PHSRST.
        /// </summary>
        public const string PHSRST = "PHSRST";

        /// <summary>
        /// PHH76BMPS.
        /// </summary>
        public const string PHH76BMPS = "PHH76BMPS";

        /// <summary>
        /// PHH76ACPS.
        /// </summary>
        public const string PHH76ACPS = "PHH76ACPS";

        /// <summary>
        /// PHH76CCPS.
        /// </summary>
        public const string PHH76CCPS = "PHH76CCPS";

        /// <summary>
        /// PHDCT.
        /// </summary>
        public const string PHDCT = "PHDCT";

        /// <summary>
        /// PHLT1OW.
        /// </summary>
        public const string PHLT1OW = "PHLT1OW";

        /// <summary>
        /// PHDGJ.
        /// </summary>
        public const string PHDGJ = "PHDGJ";

        /// <summary>
        /// PHICUT.
        /// </summary>
        public const string PHICUT = "PHICUT";

        /// <summary>
        /// PHICU.
        /// </summary>
        public const string PHICU = "PHICU";

        /// <summary>
        /// PHH76GLPS.
        /// </summary>
        public const string PHH76GLPS = "PHH76GLPS";
    }

    /// <inheritdoc />
    public override string TableName => "F76H6001";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PHH76LECO", "PHH76LECO", JdeDataType.String, 10, true, true),
        new JdeField("PHCFY", "PHCFY", JdeDataType.Numeric, null, true, true),
        new JdeField("PHFFP", "PHFFP", JdeDataType.Numeric, null, true, true),
        new JdeField("PHFTP", "PHFTP", JdeDataType.Numeric),
        new JdeField("PHDL01", "PHDL01", JdeDataType.String, 60),
        new JdeField("PHABT1", "PHABT1", JdeDataType.String, 2),
        new JdeField("PHABT2", "PHABT2", JdeDataType.String, 2),
        new JdeField("PHABT3", "PHABT3", JdeDataType.String, 2),
        new JdeField("PHABT4", "PHABT4", JdeDataType.String, 2),
        new JdeField("PHLEDG", "PHLEDG", JdeDataType.String, 4),
        new JdeField("PHLT", "PHLT", JdeDataType.String, 4),
        new JdeField("PHH76ICPS", "PHH76ICPS", JdeDataType.String, 2),
        new JdeField("PHH76WODS", "PHH76WODS", JdeDataType.String, 2),
        new JdeField("PHTBM", "PHTBM", JdeDataType.String, 6),
        new JdeField("PHSRST", "PHSRST", JdeDataType.String, 4),
        new JdeField("PHH76BMPS", "PHH76BMPS", JdeDataType.String, 2),
        new JdeField("PHH76ACPS", "PHH76ACPS", JdeDataType.String, 2),
        new JdeField("PHH76CCPS", "PHH76CCPS", JdeDataType.String, 2),
        new JdeField("PHDCT", "PHDCT", JdeDataType.String, 4),
        new JdeField("PHLT1OW", "PHLT1OW", JdeDataType.String, 4),
        new JdeField("PHDGJ", "PHDGJ", JdeDataType.Numeric),
        new JdeField("PHICUT", "PHICUT", JdeDataType.String, 4),
        new JdeField("PHICU", "PHICU", JdeDataType.Numeric),
        new JdeField("PHH76GLPS", "PHH76GLPS", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76H6001_0", "Primary Key on PHH76LECO, PHCFY, PHFFP", new[] { "PHH76LECO", "PHCFY", "PHFFP" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76H6001_2", "Index on PHH76LECO, SYS_NC00025$, SYS_NC00026$", new[] { "PHH76LECO", "SYS_NC00025$", "SYS_NC00026$" })
    };
}
