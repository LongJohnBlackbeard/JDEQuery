using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15199W - .
/// </summary>
public class F15199W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NBICU.
        /// </summary>
        public const string NBICU = "NBICU";

        /// <summary>
        /// NBDOC.
        /// </summary>
        public const string NBDOC = "NBDOC";

        /// <summary>
        /// NBMCU.
        /// </summary>
        public const string NBMCU = "NBMCU";

        /// <summary>
        /// NBGLC.
        /// </summary>
        public const string NBGLC = "NBGLC";

        /// <summary>
        /// NBBA01.
        /// </summary>
        public const string NBBA01 = "NBBA01";

        /// <summary>
        /// NBMCU3.
        /// </summary>
        public const string NBMCU3 = "NBMCU3";

        /// <summary>
        /// NBOBJ.
        /// </summary>
        public const string NBOBJ = "NBOBJ";

        /// <summary>
        /// NBSUB.
        /// </summary>
        public const string NBSUB = "NBSUB";

        /// <summary>
        /// NBBA02.
        /// </summary>
        public const string NBBA02 = "NBBA02";

        /// <summary>
        /// NBBA03.
        /// </summary>
        public const string NBBA03 = "NBBA03";

        /// <summary>
        /// NBBA04.
        /// </summary>
        public const string NBBA04 = "NBBA04";

        /// <summary>
        /// NBBCRC.
        /// </summary>
        public const string NBBCRC = "NBBCRC";

        /// <summary>
        /// NBCRCD.
        /// </summary>
        public const string NBCRCD = "NBCRCD";
    }

    /// <inheritdoc />
    public override string TableName => "F15199W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NBICU", "NBICU", JdeDataType.Numeric, null, true, true),
        new JdeField("NBDOC", "NBDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("NBMCU", "NBMCU", JdeDataType.String, 24, true, true),
        new JdeField("NBGLC", "NBGLC", JdeDataType.String, 8, true, true),
        new JdeField("NBBA01", "NBBA01", JdeDataType.Numeric),
        new JdeField("NBMCU3", "NBMCU3", JdeDataType.String, 24, true, true),
        new JdeField("NBOBJ", "NBOBJ", JdeDataType.String, 12, true, true),
        new JdeField("NBSUB", "NBSUB", JdeDataType.String, 16, true, true),
        new JdeField("NBBA02", "NBBA02", JdeDataType.Numeric),
        new JdeField("NBBA03", "NBBA03", JdeDataType.Numeric),
        new JdeField("NBBA04", "NBBA04", JdeDataType.Numeric),
        new JdeField("NBBCRC", "NBBCRC", JdeDataType.String, 6),
        new JdeField("NBCRCD", "NBCRCD", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15199W_0", "Primary Key on NBICU, NBDOC, NBMCU, NBGLC, NBMCU3, NBOBJ, NBSUB", new[] { "NBICU", "NBDOC", "NBMCU", "NBGLC", "NBMCU3", "NBOBJ", "NBSUB" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F15199W_2", "Index on NBICU, NBDOC, NBMCU, NBGLC", new[] { "NBICU", "NBDOC", "NBMCU", "NBGLC" }),
        new JdeIndex("F15199W_3", "Index on NBICU, NBDOC, NBMCU3, NBOBJ, NBSUB", new[] { "NBICU", "NBDOC", "NBMCU3", "NBOBJ", "NBSUB" })
    };
}
