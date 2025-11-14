using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09E119 - .
/// </summary>
public class F09E119 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EXEXRPTTYP.
        /// </summary>
        public const string EXEXRPTTYP = "EXEXRPTTYP";

        /// <summary>
        /// EXFROMSTA.
        /// </summary>
        public const string EXFROMSTA = "EXFROMSTA";

        /// <summary>
        /// EXNEXTSTA.
        /// </summary>
        public const string EXNEXTSTA = "EXNEXTSTA";

        /// <summary>
        /// EXREJESTA.
        /// </summary>
        public const string EXREJESTA = "EXREJESTA";

        /// <summary>
        /// EXLOGINFO.
        /// </summary>
        public const string EXLOGINFO = "EXLOGINFO";

        /// <summary>
        /// EXNOTIFY.
        /// </summary>
        public const string EXNOTIFY = "EXNOTIFY";

        /// <summary>
        /// EXAPPRID.
        /// </summary>
        public const string EXAPPRID = "EXAPPRID";

        /// <summary>
        /// EXAUDIDOV.
        /// </summary>
        public const string EXAUDIDOV = "EXAUDIDOV";

        /// <summary>
        /// EXOVMGRID.
        /// </summary>
        public const string EXOVMGRID = "EXOVMGRID";

        /// <summary>
        /// EXOVAUDID.
        /// </summary>
        public const string EXOVAUDID = "EXOVAUDID";

        /// <summary>
        /// EXAUDAPROV.
        /// </summary>
        public const string EXAUDAPROV = "EXAUDAPROV";

        /// <summary>
        /// EXMGRAPROV.
        /// </summary>
        public const string EXMGRAPROV = "EXMGRAPROV";

        /// <summary>
        /// EXUSER.
        /// </summary>
        public const string EXUSER = "EXUSER";

        /// <summary>
        /// EXPID.
        /// </summary>
        public const string EXPID = "EXPID";

        /// <summary>
        /// EXUPMT.
        /// </summary>
        public const string EXUPMT = "EXUPMT";

        /// <summary>
        /// EXJOBN.
        /// </summary>
        public const string EXJOBN = "EXJOBN";

        /// <summary>
        /// EXUPMJ.
        /// </summary>
        public const string EXUPMJ = "EXUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F09E119";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EXEXRPTTYP", "EXEXRPTTYP", JdeDataType.String, 2, true, true),
        new JdeField("EXFROMSTA", "EXFROMSTA", JdeDataType.String, 6, true, true),
        new JdeField("EXNEXTSTA", "EXNEXTSTA", JdeDataType.String, 6),
        new JdeField("EXREJESTA", "EXREJESTA", JdeDataType.String, 6),
        new JdeField("EXLOGINFO", "EXLOGINFO", JdeDataType.String, 2),
        new JdeField("EXNOTIFY", "EXNOTIFY", JdeDataType.String, 2),
        new JdeField("EXAPPRID", "EXAPPRID", JdeDataType.Numeric),
        new JdeField("EXAUDIDOV", "EXAUDIDOV", JdeDataType.Numeric),
        new JdeField("EXOVMGRID", "EXOVMGRID", JdeDataType.String, 2),
        new JdeField("EXOVAUDID", "EXOVAUDID", JdeDataType.String, 2),
        new JdeField("EXAUDAPROV", "EXAUDAPROV", JdeDataType.String, 2),
        new JdeField("EXMGRAPROV", "EXMGRAPROV", JdeDataType.String, 2),
        new JdeField("EXUSER", "EXUSER", JdeDataType.String, 20),
        new JdeField("EXPID", "EXPID", JdeDataType.String, 20),
        new JdeField("EXUPMT", "EXUPMT", JdeDataType.Numeric),
        new JdeField("EXJOBN", "EXJOBN", JdeDataType.String, 20),
        new JdeField("EXUPMJ", "EXUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09E119_0", "Primary Key on EXEXRPTTYP, EXFROMSTA", new[] { "EXEXRPTTYP", "EXFROMSTA" }, isUnique: true, isPrimaryKey: true)
    };
}
