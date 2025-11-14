using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF31K50 - .
/// </summary>
public class FF31K50 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DFFSCID.
        /// </summary>
        public const string DFFSCID = "DFFSCID";

        /// <summary>
        /// DFDFMCU.
        /// </summary>
        public const string DFDFMCU = "DFDFMCU";

        /// <summary>
        /// DFDFDMCU.
        /// </summary>
        public const string DFDFDMCU = "DFDFDMCU";

        /// <summary>
        /// DFSFTHR.
        /// </summary>
        public const string DFSFTHR = "DFSFTHR";

        /// <summary>
        /// DFLBLKAN.
        /// </summary>
        public const string DFLBLKAN = "DFLBLKAN";

        /// <summary>
        /// DFLBLNRK.
        /// </summary>
        public const string DFLBLNRK = "DFLBLNRK";

        /// <summary>
        /// DFDCLBL.
        /// </summary>
        public const string DFDCLBL = "DFDCLBL";

        /// <summary>
        /// DFKANFAS.
        /// </summary>
        public const string DFKANFAS = "DFKANFAS";

        /// <summary>
        /// DFURCD.
        /// </summary>
        public const string DFURCD = "DFURCD";

        /// <summary>
        /// DFURDT.
        /// </summary>
        public const string DFURDT = "DFURDT";

        /// <summary>
        /// DFURRF.
        /// </summary>
        public const string DFURRF = "DFURRF";

        /// <summary>
        /// DFURAT.
        /// </summary>
        public const string DFURAT = "DFURAT";

        /// <summary>
        /// DFURAB.
        /// </summary>
        public const string DFURAB = "DFURAB";

        /// <summary>
        /// DFTORG.
        /// </summary>
        public const string DFTORG = "DFTORG";

        /// <summary>
        /// DFUSER.
        /// </summary>
        public const string DFUSER = "DFUSER";

        /// <summary>
        /// DFJOBN.
        /// </summary>
        public const string DFJOBN = "DFJOBN";

        /// <summary>
        /// DFPID.
        /// </summary>
        public const string DFPID = "DFPID";

        /// <summary>
        /// DFUUPMJ.
        /// </summary>
        public const string DFUUPMJ = "DFUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "FF31K50";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DFFSCID", "DFFSCID", JdeDataType.Numeric, null, true, true),
        new JdeField("DFDFMCU", "DFDFMCU", JdeDataType.String, 24, true, true),
        new JdeField("DFDFDMCU", "DFDFDMCU", JdeDataType.String, 2),
        new JdeField("DFSFTHR", "DFSFTHR", JdeDataType.Numeric),
        new JdeField("DFLBLKAN", "DFLBLKAN", JdeDataType.String, 6),
        new JdeField("DFLBLNRK", "DFLBLNRK", JdeDataType.String, 6),
        new JdeField("DFDCLBL", "DFDCLBL", JdeDataType.String, 6),
        new JdeField("DFKANFAS", "DFKANFAS", JdeDataType.Numeric),
        new JdeField("DFURCD", "DFURCD", JdeDataType.String, 4),
        new JdeField("DFURDT", "DFURDT", JdeDataType.Numeric),
        new JdeField("DFURRF", "DFURRF", JdeDataType.String, 30),
        new JdeField("DFURAT", "DFURAT", JdeDataType.Numeric),
        new JdeField("DFURAB", "DFURAB", JdeDataType.Numeric),
        new JdeField("DFTORG", "DFTORG", JdeDataType.String, 20),
        new JdeField("DFUSER", "DFUSER", JdeDataType.String, 20),
        new JdeField("DFJOBN", "DFJOBN", JdeDataType.String, 20),
        new JdeField("DFPID", "DFPID", JdeDataType.String, 20),
        new JdeField("DFUUPMJ", "DFUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF31K50_0", "Primary Key on DFFSCID, DFDFMCU", new[] { "DFFSCID", "DFDFMCU" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF31K50_2", "Index on DFFSCID, DFDFDMCU", new[] { "DFFSCID", "DFDFDMCU" })
    };
}
